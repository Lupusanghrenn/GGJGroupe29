using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHeavyObject : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] heavyObjects;

    public bool mustSpawn = false;

    void Start()
    {

    }

    private void SpawnObject()
    {
        int rand1 = Random.Range(0, heavyObjects.Length - 1);
        int rand2 = Random.Range(0, spawnLocations.Length - 1);

        Vector3 spawnPosition = new Vector3(spawnLocations[rand2].position.x, spawnLocations[rand2].position.y, 30f);
        Instantiate(heavyObjects[rand1], spawnPosition, Quaternion.identity);
    }

    void Update()
    {

    }
}
