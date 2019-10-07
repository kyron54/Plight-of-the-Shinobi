using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    void OnMouseDown()
    {

        Invoke("StartGame", 0.25f);
        
    }

    void StartGame()
    {

        SceneManager.LoadScene("Game");

    }
}

