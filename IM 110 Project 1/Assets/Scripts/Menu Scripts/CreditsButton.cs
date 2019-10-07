using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{


    void OnMouseDown()
    {

        Invoke("OpenCredits", 0.25f);

    }

    void OpenCredits()
    {

        SceneManager.LoadScene("Credits");

    }
}
