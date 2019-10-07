using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer_2_Movement : MonoBehaviour
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
            transform.position += Vector3.left * Time.deltaTime * GlobalValues.gameSpeed/2;
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

            transform.position = new Vector3(xPos, m_otherbackground.transform.position.y, 3f);
        }
    }

    void ChangeBackgorundArt()
    {
        int randomNumber = Random.Range(0, 99);

        if (randomNumber < m_bg1_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile_1_layer2");
        }
        else if (randomNumber < m_bg1_percent + m_bg2_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile_2_layer2");
        }
        else if (randomNumber < m_bg1_percent + m_bg3_percent)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile_3_layer2");
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/tile_3_layer2");
        }



    }

}
