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

    void OnMouseOver()
    {

        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Main Menu/Play_Down");

    }

    void OnMouseExit()
    {

        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Main Menu/Play");

    }
}

