using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{

    public float        m_speed = -5f;
    public GameObject   m_otherbackground;
    public int          m_bg1_percent = 25;
    public int          m_bg2_percent = 25;
    public int          m_bg3_percent = 25;
    public int          m_bg4_percent = 25;

    // Update is called once per frame
    void Update()
    {

        transform.position += new Vector3(m_speed * Time.deltaTime, 0, 0);
       
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
        int randomNumber = Random.Range(0, 101);

        Debug.Log(randomNumber);

        if(randomNumber < m_bg1_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile1");
        }
        else if(randomNumber < m_bg1_percent + m_bg2_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile2");
        }
        else if (randomNumber < m_bg1_percent + m_bg3_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile3");
        }
        else 
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile4");
        }



    }

}
