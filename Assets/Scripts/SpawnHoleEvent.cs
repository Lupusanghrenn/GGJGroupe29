using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHoleEvent : MonoBehaviour
{
    public GameObject boat;
    public bool mustSpawn = false;

    public GameObject holePrefab;

    public BoxCollider spawnArea;

    private void SpawnHole()
    {
        Debug.Log(spawnArea.bounds.max.y);
        float randomX = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        float randomZ = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);

        Instantiate(holePrefab, new Vector3(randomX, spawnArea.bounds.max.y + 0.01f, randomZ),
                                                        Quaternion.Euler(new Vector3(0, 90, 0)),
                                                        boat.transform);
    }

    void Update()
    {
        if(mustSpawn)
        {
            SpawnHole();
            mustSpawn = false;
        }
    }
}
