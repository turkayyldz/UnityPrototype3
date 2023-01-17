using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRb;
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGraund=true;

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
       
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isOnGraund)
        {
            _playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGraund = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGraund = true;
    }
}
