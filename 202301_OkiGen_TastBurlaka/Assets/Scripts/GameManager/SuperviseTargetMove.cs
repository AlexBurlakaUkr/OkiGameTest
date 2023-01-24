using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SuperviseTargetMove : MonoBehaviour
{
    public float xPosition = 0.5f;
    public float speed = 1f;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if (transform.position.x >= xPosition) speed *= -1;
        else if(transform.position.x <= -xPosition) speed *= -1;
    }
}
