using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxController : MonoBehaviour
{

    float lastSpawnTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Object.Destroy(gameObject, .1f);

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {

            HitBoxManager.canAttack = false;

            if (Time.time > lastSpawnTime + 2)
            {
                HitBoxManager.canAttack = true;
                lastSpawnTime = Time.time;
                Object.Destroy(gameObject);
            }
        }



    }


}
