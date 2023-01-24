using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlusOneMove : MonoBehaviour
{
    [SerializeField] private Vector3 movementSpeed;
    [SerializeField] private Space space;
    [SerializeField] private float timeToDestroy;
    private void Start() => Destroy(gameObject, timeToDestroy);
    public void Update() => transform.Translate(movementSpeed * Time.deltaTime, space);

}
