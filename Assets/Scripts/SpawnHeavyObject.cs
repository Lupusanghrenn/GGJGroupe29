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
        int rand1 = Random.Range(0, heavyObjects.Length);
        int rand2 = Random.Range(0, spawnLocations.Length);

        Vector3 spawnPosition = new Vector3(spawnLocations[rand2].position.x, 30f, spawnLocations[rand2].position.z);
        Instantiate(heavyObjects[rand1], spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("Level").transform);
    }

    void Update()
    {
        if(mustSpawn)
        {
            SpawnObject();
            mustSpawn = false;
        }
    }
}
