using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxManager : MonoBehaviour
{

   public static bool canAttack = true;

    public GameObject hitBoxPrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       // Debug.Log("canAttack: " + canAttack);

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (canAttack = true)
            {
               // Debug.Log("Hitbox Drawn");
                CreateHitBox();
            } 
        }



    }

    void CreateHitBox()
    {

        float avatarPos = GameObject.Find("avatar").transform.position.y;


        GameObject obj = Instantiate(hitBoxPrefab, transform);
        obj.transform.position = new Vector3(-5f, avatarPos, -2f);

    }


}
