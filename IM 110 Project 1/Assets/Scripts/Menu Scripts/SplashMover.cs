using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashMover : MonoBehaviour
{

    float speed = .001f;
    float delta = .1f;  //delta is the difference between min y to max y.
    public float y;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {

        if(y == 3.5f)
        {

            GoUp();

        }

        if (y == 1.5f)
        {

            GoDown();

        }

        

    }

    void GoUp()
    {

        y = transform.position.y + Mathf.PingPong(speed * Time.time, delta);
        Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = pos;

    }

    void GoDown()
    {

        y = transform.position.y - Mathf.PingPong(speed * Time.time, delta);
        Vector3 pos = new Vector3(transform.position.x, y, transform.position.z);
        transform.position = pos;

    }

}
