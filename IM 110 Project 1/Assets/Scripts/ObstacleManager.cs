using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    public GameObject obstaclePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 0.25f, 2f);
    }

    // Creates Obstacle
    void CreateObstacle()
    {
        GameObject obj = Instantiate(obstaclePrefab, transform);
        obj.transform.position = new Vector3(10f, -3f, -2f);
    }
}
