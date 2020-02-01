using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHeavyObjectEvent : MonoBehaviour
{
    public GameObject boat;

    public GameObject spawnLocationGameObject;
    public GameObject[] heavyObjects;

    private Transform[] spawnLocations;

    public bool mustSpawn = false;

    void Start()
    {
        spawnLocations = new Transform[spawnLocationGameObject.transform.childCount];

        for (int i = 0; i < spawnLocationGameObject.transform.childCount; i++)
        {
            spawnLocations[i] = spawnLocationGameObject.transform.GetChild(i);
        }
    }

    private void SpawnObject()
    {
        int rand1 = Random.Range(0, heavyObjects.Length);
        int rand2 = Random.Range(0, spawnLocations.Length);

        Vector3 spawnPosition = new Vector3(spawnLocations[rand2].position.x, 30f, spawnLocations[rand2].position.z);
        Instantiate(heavyObjects[rand1], spawnPosition, Quaternion.identity, boat.transform);
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
