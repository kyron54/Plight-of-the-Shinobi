using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsController : MonoBehaviour
{


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Invoke("OpenMenu", 0.25f);

        }

    }


    void OpenMenu()
    {

        SceneManager.LoadScene("Main Menu");

    }
}
