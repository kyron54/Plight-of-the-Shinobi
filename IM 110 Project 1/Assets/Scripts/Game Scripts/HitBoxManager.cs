using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxManager : MonoBehaviour
{

   public static bool canAttack = true;

    public GameObject hitBoxPrefab;
    float lastSpawnTime = 0f;


    // Start is called before the first frame update
    void Start()
    {

        canAttack = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (canAttack && !AvatarActions.playerDead)
        {

            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {


                CreateHitBox();
                canAttack = false;


            }
        }

        CanAttackUpdate();

    }

    void CanAttackUpdate()
    {

        if (Time.time > lastSpawnTime + 1f)
        {

            canAttack = true;

        }

    }

    void CreateHitBox()
    {

        lastSpawnTime = Time.time;

        float avatarPos = GameObject.Find("avatar").transform.position.y;


        GameObject obj = Instantiate(hitBoxPrefab, transform);
        obj.transform.position = new Vector3(-5f, avatarPos, -2f);


    }


}
