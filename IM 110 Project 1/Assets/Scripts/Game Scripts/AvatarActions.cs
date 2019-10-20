using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AvatarActions : MonoBehaviour
{
    public static float playerHealth = 3f;
    bool canJump = true;
    public static bool playerDead;
    public Text scoreText;
    int score = 0;
    public Text liveText;
    float lastSpawnTime = 0f;
    float jumpCount = 0f;
    public Text replayText;
    AudioSource sndSlice; // Sound Provided by Tabook on freesound.org: https://freesound.org/people/Tabook/sounds/431221/
    AudioSource sndJump; // Sound Provided bt nextmaking on freesound.org https://freesound.org/people/nextmaking/sounds/86007/
    AudioSource sndHit; // Sound Provided by Raclure on freesound.org https://freesound.org/people/Raclure/sounds/458867/
    AudioSource sndItem; // Sound Provided by TreasureSounds on freesound.org https://freesound.org/people/TreasureSounds/sounds/332629/

    private void Start()
    {
        playerDead = false;
        InvokeRepeating("UpdateScore", 1f, .2f);
        InvokeRepeating("UpdateLives", 1f, .01f);

        AudioSource[] src = GetComponents<AudioSource>();

        sndSlice = src[0];
        sndJump = src[1];
        sndHit = src[2];
        sndItem = src[3];
    }

    void UpdateScore()
    {
        if (playerDead == false)
        {
            score = score + 1;
            scoreText.text = "Score: " + score;

        }

        if(playerDead == true)
        {

            score = score +0;

        }

    }

    void UpdateLives()
    {
        if (playerDead == false)
        {
            liveText.text = "Lives: " + playerHealth;
        } 
    
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {

            jumpCount = jumpCount + 1;

            if (jumpCount <= 2f)
            {
                canJump = false;

                GetComponent<Animator>().SetBool("Jump", true);

                sndJump.Play();

                // code taken from https://stackoverflow.com/questions/25350411/unity-2d-jumping-script
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7), ForceMode2D.Impulse);


            }

        }

        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            

            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -10), ForceMode2D.Impulse);


        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

                if (HitBoxManager.canAttack && !playerDead)
                {

                    GetComponent<Animator>().SetBool("Attack", true);
                    sndSlice.Play();

                }

        }
        

        if (Time.time > lastSpawnTime + .5)
        {
            lastSpawnTime = Time.time;
            GetComponent<Animator>().SetBool("Attack", false);
        }


        if (playerHealth <= 0f)
        {
            playerDead = true;
            GetComponent<Animator>().SetBool("Death", true);

            if (playerDead)
            {
                
                liveText.text = "Lives: 0";
                //Object.Destroy(gameObject);
                canJump = false;
                
            }
        }

        if (playerDead)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                GlobalValues.gameSpeed = 2f;
                playerHealth = 3f;
                lastSpawnTime = 0f;
                score = 0;
                playerDead = false;
                Invoke("OpenMenu", 0f);

            }

        }

    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        
            if (coll.gameObject.tag == "Ground" && !canJump && !playerDead)
            {
                canJump = true;
                jumpCount = 0f;
                GetComponent<Animator>().SetBool("Jump", false);
            }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            sndHit.Play();

        }

        if (other.gameObject.tag == "Item")
        {

            sndItem.Play();

        }

    }

    void OpenMenu()
    {

        SceneManager.LoadScene("Main Menu");

    }

    public void OnMouseDown()
    {
        if (playerDead)
        {
            GlobalValues.gameSpeed = 2f;
            playerHealth = 3f;
            lastSpawnTime = 0f;
            score = 0;
            playerDead = false;
            Invoke("OpenMenu", 0f);
        }

    }


}
