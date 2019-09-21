using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    public float speedAdjustment = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (AvatarActions.playerDead == false)
        

            transform.position += Vector3.left * Time.deltaTime * (GlobalValues.gameSpeed + speedAdjustment);
        

        if (transform.position.x < -10)
        {
            Object.Destroy(gameObject);
        }

      //  Debug.Log("Health " + AvatarActions.playerHealth);
       // Debug.Log("Is dead? " + AvatarActions.playerDead);

    }


    void OnTriggerEnter2D(Collider2D other)
    {

        AvatarActions.playerHealth--;
        Object.Destroy(gameObject);

    }
}
