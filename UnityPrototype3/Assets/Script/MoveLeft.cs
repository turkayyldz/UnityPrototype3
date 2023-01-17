using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float leftBound = -15;
    private float _speed = 30f;
    private PlayerController _playerController;
    void Start()
    {
        _playerController =GameObject.Find("Player").GetComponent<PlayerController>();
        
    }
    void Update()
    {
        if (_playerController.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }

}

