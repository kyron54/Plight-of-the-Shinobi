using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalValues : MonoBehaviour
{

    public static float gameSpeed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameSpeed += Time.deltaTime/6;


        if(gameSpeed >= 22)
        {

            gameSpeed = 22;

        }

    }
}
