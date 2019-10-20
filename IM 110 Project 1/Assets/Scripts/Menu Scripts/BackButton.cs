using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    void OnMouseDown()
    {

        Invoke("OpenMenu", 0.25f);

    }

    void OpenMenu()
    {

        SceneManager.LoadScene("Main Menu");

    }

    void OnMouseOver()
    {

        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Main Menu/BackButton_Down");

    }

    void OnMouseExit()
    {

        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Main Menu/BackButton");

    }
}
