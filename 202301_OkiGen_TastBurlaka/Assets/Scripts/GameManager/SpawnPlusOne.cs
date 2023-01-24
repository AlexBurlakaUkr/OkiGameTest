using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlusOne : MonoBehaviour
{
    [SerializeField] private GameObject plusOnePrefab;
    private void Start()
    {
        GlobalEventManager.OnFruitCounter.AddListener(GetSpawnPlusOne);
    }
    private void GetSpawnPlusOne()
    {
        Instantiate(plusOnePrefab, transform.position, Quaternion.identity, transform);
    }
}
