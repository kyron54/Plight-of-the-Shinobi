using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public GameObject trapPrefab;
    public float spawnRate = 12f;
    float lastSpawnTime = 0f;

    // Start is called before the first frame update
    void Update()
    {

        int randomNumber1 = Random.Range(0, 5000);
        int randomNumber2 = Random.Range(0, 5000);

        if (Time.time > lastSpawnTime + randomNumber1/GlobalValues.gameSpeed)
        {
            lastSpawnTime = Time.time;
            CreateObstacle();
        }

        if (Time.time > lastSpawnTime + randomNumber2 / GlobalValues.gameSpeed)
        {
            lastSpawnTime = Time.time;
            CreateSpike();
        }
    }

    // Creates Obstacle
    void CreateObstacle()
    {
        GameObject obj = Instantiate(obstaclePrefab, transform);
        obj.transform.position = new Vector3(10f, -3f, -2f);
    }

    void CreateSpike()
    {

        GameObject obj = Instantiate(trapPrefab, transform);
        obj.transform.position = new Vector3(10f, -3f, -2f);

    }
}
