using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{

    AvatarActions ClickToRestart;
       
    // Start is called before the first frame update
    void Start()
    {

        

    }

    // Update is called once per frame
    void PopIn()
    {

        if (AvatarActions.playerDead)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Main Menu/BackButton");
        }

    }

    void OnMouseDown()
    {
        if (AvatarActions.playerDead)
        {

            ClickToRestart = gameObject.GetComponent("avatar") as AvatarActions;

            ClickToRestart.OnMouseDown();

        }

    }

    void OpenMenu()
    {

        SceneManager.LoadScene("Main Menu");

    }

    void OnMouseOver()
    {
        if (AvatarActions.playerDead)
        {

            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Main Menu/BackButton_Down");
        }

    }

    void OnMouseExit()
    {
        if (AvatarActions.playerDead)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Main Menu/BackButton");
        }

    }
}
