using System.Collections.Generic;
using UnityEngine;

public class SpawnConveyor : MonoBehaviour
{
    [SerializeField] private List<GameObject> conveyors= new List<GameObject>();
    [SerializeField] private float conveyorLength = 10f;
    private GameObject conveyor;
    private void Start()
    {
        conveyor = GetSpawnConveyor(transform.position);
    }
    public void Spawn()
    {
        Vector3 position = new Vector3(conveyor.transform.position.x - conveyorLength, conveyor.transform.position.y, conveyor.transform.position.z);
        conveyor = GetSpawnConveyor(position);
    }
    private GameObject GetSpawnConveyor(Vector3 spawnStart)
    {
        GameObject _conveyor = Instantiate(conveyors[Random.Range(0, conveyors.Count)], spawnStart, Quaternion.identity, transform);
        return _conveyor;
    }
}
