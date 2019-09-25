using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarActions : MonoBehaviour
{
    public static float playerHealth = 3f;
    bool canJump = true;
    public static bool playerDead;
    public Text scoreText;
    int score = 0;
    public Text liveText;
    float lastSpawnTime = 0f;

    private void Start()
    {
        playerDead = false;
        InvokeRepeating("UpdateScore", 1f, .2f);
        InvokeRepeating("UpdateLives", 1f, .01f);

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

            score = score;

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
            if (canJump)
            {
                canJump = false;

                GetComponent<Animator>().SetBool("Jump", true);

                // code taken from https://stackoverflow.com/questions/25350411/unity-2d-jumping-script
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
                HitBoxManager.canAttack = false;

            }

        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (HitBoxManager.canAttack = true)
            {

                GetComponent<Animator>().SetBool("Attack", true);
                HitBoxManager.canAttack = false;

            }

        }

        if (Time.time > lastSpawnTime + .5)
        {
            lastSpawnTime = Time.time;
            GetComponent<Animator>().SetBool("Attack", false);
        }

            if (HitBoxManager.canAttack = false)
            {


                HitBoxManager.canAttack = true;

            }


        playerDead = false;

        if (playerHealth <= 0)
        {
            playerDead = true;
            GetComponent<Animator>().SetBool("Death", true);

            if (playerDead = true)
            {
                
                liveText.text = "Lives: 0";
                //Object.Destroy(gameObject);
                canJump = false;
                
            }
        }


    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground" && !canJump)
        {
            canJump = true;
            HitBoxManager.canAttack = true;

            GetComponent<Animator>().SetBool("Jump", false);
        }
    }
}
