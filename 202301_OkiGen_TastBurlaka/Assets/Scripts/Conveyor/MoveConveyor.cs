using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveConveyor : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float destroyPoint = 7f;
    private void Update()
    {
        DectroyConveyor();
    }

    private void DectroyConveyor()
    {
        if(transform.position.x > destroyPoint) Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(transform.right * speed * Time.fixedDeltaTime);
    }
}
