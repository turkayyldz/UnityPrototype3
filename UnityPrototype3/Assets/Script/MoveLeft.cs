using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private float _speed = 30f;

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
    }
}
