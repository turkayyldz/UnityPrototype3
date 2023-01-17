using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private Vector3 _spawnPos = new Vector3(25, 0, 0);
    public GameObject obstaclePrefab;
    private float startDelay =2;
    private float repeatRate = 2;
    private PlayerController _playerController;
    void Start()
    {
        
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

  void SpawnObstacle()
    {
        if (_playerController.gameOver==false)
        {
            Instantiate(obstaclePrefab, _spawnPos, obstaclePrefab.transform.rotation);
        }
       
    }
}
