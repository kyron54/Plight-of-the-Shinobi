using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarActions : MonoBehaviour
{
    public static float playerHealth = 3f;
    bool canJump = true;
    public static bool playerDead;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (canJump)
            {
                canJump = false;

                // code taken from https://stackoverflow.com/questions/25350411/unity-2d-jumping-script
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7), ForceMode2D.Impulse);
            }

        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Attack!");
        }

        playerDead = false;

        if (playerHealth <= 0)
        {
            playerDead = true;

            if (playerDead = true)
            {
                Object.Destroy(gameObject);
            }
        }


    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }
}
