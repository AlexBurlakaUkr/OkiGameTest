using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStart : MonoBehaviour
{
    [SerializeField] private SpawnConveyor spawnConveyor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Conveyor"))
        {
            spawnConveyor.Spawn();
        }
    }
}
