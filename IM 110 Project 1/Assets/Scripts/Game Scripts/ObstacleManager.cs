using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public GameObject trapPrefab;
    public GameObject healthPrefab;
    public float spawnRate = 12f;
    float lastSpawnTime1 = 0f;
    float lastSpawnTime2 = 0f;
    float lastSpawnTime3 = 0f;

    // Start is called before the first frame update
    void Start()
    {


    }

    void Update()
    {

        int randomNumber1 = Random.Range(0, 5000);
        int randomNumber2 = Random.Range(0, 5000);
        int randomNumber3 = Random.Range(0, 50000);

        if (Time.time >= lastSpawnTime1 + randomNumber1/spawnRate)
        {
            lastSpawnTime1 = Time.time;
            CreateObstacle();
        }

        if (Time.time >= lastSpawnTime2 + randomNumber2 / GlobalValues.gameSpeed)
        {
            lastSpawnTime2 = Time.time;
            CreateSpike();
        }

        if (Time.time >= lastSpawnTime3 + randomNumber3 / GlobalValues.gameSpeed)
        {
            lastSpawnTime3 = Time.time;
            CreateHealth();
        }


        spawnRate = GlobalValues.gameSpeed * 1.2f;

    }

    // Creates Obstacle
    void CreateObstacle()
    {
        if (!AvatarActions.playerDead)
        {
            GameObject obj = Instantiate(obstaclePrefab, transform);
            obj.transform.position = new Vector3(10f, -3f, -2f);
        }
    }

    void CreateSpike()
    {
        if (!AvatarActions.playerDead)
        {
            GameObject obj = Instantiate(trapPrefab, transform);
            obj.transform.position = new Vector3(10f, -3f, -2f);
        }

    }

    void CreateHealth()
    {
        if (!AvatarActions.playerDead)
        {
            GameObject obj = Instantiate(healthPrefab, transform);
            obj.transform.position = new Vector3(10f, -3f, -2f);
        }

    }

}
