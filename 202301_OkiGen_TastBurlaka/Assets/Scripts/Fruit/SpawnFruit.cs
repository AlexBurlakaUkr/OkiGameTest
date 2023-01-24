using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruit : MonoBehaviour
{
    [SerializeField] private List<GameObject> fruitsPrefab = new List<GameObject>();
    [SerializeField] private Vector3 spawnPosition;
    [SerializeField] private float spawnFruitInterval;
    private List<GameObject> spawnFruits = new List<GameObject>();
    private GameObject fruit;
    private float startSpawnTime = 1f;

    private void Start()
    {
        InvokeRepeating("GetSpawnFruits", startSpawnTime, spawnFruitInterval);
    }

    private GameObject GetSpawnFruits()
    {
        GameObject _spawbFruit = Instantiate(fruitsPrefab[Random.Range(0, fruitsPrefab.Count)], spawnPosition, Quaternion.identity, transform);
        return _spawbFruit;
    }
}
