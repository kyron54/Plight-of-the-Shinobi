using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObstacleManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public GameObject trapPrefab;
    public float spawnRate = 12f;
    float lastSpawnTime = 0f;

    // Start is called before the first frame update
    void Start()
    {


    }

    void Update()
    {

        int randomNumber1 = Random.Range(0, 5000);
        int randomNumber2 = Random.Range(0, 5000);

        if (Time.time >= lastSpawnTime + randomNumber1/spawnRate)
        {
            lastSpawnTime = Time.time;
            CreateObstacle();
        }

        if (Time.time >= lastSpawnTime + randomNumber2 / GlobalValues.gameSpeed)
        {
            lastSpawnTime = Time.time;
            CreateSpike();
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

}
