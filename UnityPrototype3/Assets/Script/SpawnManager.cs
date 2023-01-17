using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3 _spawnPos = new Vector3(25, 0, 0);
    public GameObject obstaclePrefab;
    private float startDelay =2;
    private float repeatRate = 2;
    void Start()
    {
        
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

  void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, _spawnPos, obstaclePrefab.transform.rotation);
    }
}
