using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    public float spawnRate = 12f;
    float lastSpawnTime = 0f;

    // Start is called before the first frame update
    void Update()
    {
        if(Time.time > lastSpawnTime + spawnRate/GlobalValues.gameSpeed)
        {
            lastSpawnTime = Time.time;
            CreateObstacle();
        }
    }

    // Creates Obstacle
    void CreateObstacle()
    {
        GameObject obj = Instantiate(obstaclePrefab, transform);
        obj.transform.position = new Vector3(10f, -3f, -2f);
    }
}
