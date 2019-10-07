using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer3Movement : MonoBehaviour
{
    public GameObject m_otherbackground;
    public int m_bg1_percent = 25;
    public int m_bg2_percent = 25;
    public int m_bg3_percent = 25;
    public int m_bg4_percent = 25;

    // Update is called once per frame
    void Update()
    {
        if (AvatarActions.playerDead == false)
        {
            transform.position += Vector3.left * Time.deltaTime * GlobalValues.gameSpeed/3;
        }

    }

    private void LateUpdate()
    {
        if (transform.position.x <= -22)
        {
            ChangeBackgorundArt();

            float otherHalfWidth = m_otherbackground.GetComponent<SpriteRenderer>().bounds.extents.x;
            float myHalfWidth = GetComponent<SpriteRenderer>().bounds.extents.x;

            float xPos = m_otherbackground.transform.position.x + otherHalfWidth + myHalfWidth;
            xPos -= 0.25f;

            transform.position = new Vector3(xPos, m_otherbackground.transform.position.y, m_otherbackground.transform.position.z);
        }
    }

    void ChangeBackgorundArt()
    {
        int randomNumber = Random.Range(0, 99);

        if (randomNumber < m_bg1_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Background 1-3");
        }
        else if (randomNumber < m_bg1_percent + m_bg2_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Background 2-3");
        }
        else if (randomNumber < m_bg1_percent + m_bg3_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Background 3-3");
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Background 4-3");
        }



    }

}
