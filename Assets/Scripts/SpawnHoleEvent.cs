using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHoleEvent : MonoBehaviour
{
    private GameObject boat;
    private GameObject water;
    public GameObject holePrefab;

    private BoxCollider spawnArea;

    public bool mustSpawn = false;

    public float baseWaterSpeed;

    private void Start()
    {
        boat = GameObject.FindGameObjectWithTag("Boat");
        spawnArea = boat.transform.GetChild(0).GetChild(2).gameObject.GetComponent<BoxCollider>();

        SpawnHole();
        Destroy(this.gameObject);
    }
    private void SpawnHole()
    {
        float randomX = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        float randomZ = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);

        Instantiate(holePrefab, new Vector3(randomX, spawnArea.bounds.max.y + 0.01f, randomZ),
                                                        Quaternion.Euler(new Vector3(boat.transform.rotation.x, 0, 0)),
                                                        boat.transform); // TODO : Get Spawn Area rotation to rotate the sprite

    }
}
