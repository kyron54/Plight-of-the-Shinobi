using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Vector3.left * Time.deltaTime * speed;

        if (transform.position.x < -10)
        {
            Object.Destroy(gameObject);
        }

        Debug.Log("Health " + AvatarActions.playerHealth);
        Debug.Log("Is dead? " + AvatarActions.playerDead);

    }


    void OnTriggerEnter2D(Collider2D other)
    {

        AvatarActions.playerHealth--;
        Object.Destroy(gameObject);

    }



}
