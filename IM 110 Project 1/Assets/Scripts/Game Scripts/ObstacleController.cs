﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleController : MonoBehaviour
{

    public float speedAdjustment = 1f;
    public Text killsText;
    int kills = 0;

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

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "avatar")
        {
            AvatarActions.playerHealth--;
            Object.Destroy(gameObject);
            
        }

        else
        {

            Object.Destroy(gameObject);
            InvokeRepeating("UpdateKills", 1f, .01f);

        }

    }

    void UpdateKills()
    {

        kills = kills + 1;
        killsText.text = "Kills: " + kills;

    }


}