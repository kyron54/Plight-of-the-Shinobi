using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{

    public GameObject   m_otherbackground;
    public int          m_bg1_percent = 25;
    public int          m_bg2_percent = 25;
    public int          m_bg3_percent = 25;
    public int          m_bg4_percent = 25;

    // Update is called once per frame
    void Update()
    {
        if (AvatarActions.playerDead == false)
        {
            transform.position += Vector3.left * Time.deltaTime * GlobalValues.gameSpeed;
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

            transform.position = new Vector3(xPos, m_otherbackground.transform.position.y);
        }
    }

    void ChangeBackgorundArt()
    {
        int randomNumber = Random.Range(0, 99);

       // Debug.Log(randomNumber);

        if(randomNumber < m_bg1_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile_1_close");
        }
        else if(randomNumber < m_bg1_percent + m_bg2_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile_2_close");
        }
        else if (randomNumber < m_bg1_percent + m_bg3_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile_3_close");
        }
        else 
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile_4_close");
        }



    }

}
