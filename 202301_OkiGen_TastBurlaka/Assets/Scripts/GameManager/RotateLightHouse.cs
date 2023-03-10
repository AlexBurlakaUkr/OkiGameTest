using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLightHouse : MonoBehaviour
{
    [SerializeField] Vector3 rotationSpeed;
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
