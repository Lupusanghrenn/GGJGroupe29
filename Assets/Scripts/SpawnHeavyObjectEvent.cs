using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHeavyObjectEvent : MonoBehaviour
{
    private GameObject boat;

    private GameObject spawnLocations;
    public GameObject[] heavyObjects;

    private Transform[] spawnLocationsArray;

    void Start()
    {
        boat = GameObject.FindGameObjectWithTag("Boat");
        spawnLocations = boat.transform.GetChild(1).gameObject;

        spawnLocationsArray = new Transform[spawnLocations.transform.childCount];

        for (int i = 0; i < spawnLocations.transform.childCount; i++)
        {
            spawnLocationsArray[i] = spawnLocations.transform.GetChild(i);
        }

        SpawnObject();

        Destroy(this.gameObject);
    }

    private void SpawnObject()
    {
        int rand1 = Random.Range(0, heavyObjects.Length);
        int rand2 = Random.Range(0, spawnLocationsArray.Length);

        Vector3 spawnPosition = new Vector3(spawnLocationsArray[rand2].position.x, 30f, spawnLocationsArray[rand2].position.z);
        Instantiate(heavyObjects[rand1], spawnPosition, Quaternion.identity, boat.transform);
    }
}
