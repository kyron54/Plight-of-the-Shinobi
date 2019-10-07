using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsButton : MonoBehaviour
{

    void OnMouseDown()
    {

        Invoke("OpenInstructions", 0.25f);

    }

    void OpenInstructions()
    {

        SceneManager.LoadScene("Instructions");

    }
}
