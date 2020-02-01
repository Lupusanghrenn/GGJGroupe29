using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHoleEvent : MonoBehaviour
{
    public GameObject boat;
    public GameObject water;
    public GameObject holePrefab;

    public BoxCollider spawnArea;

    public bool mustSpawn = false;

    public float baseWaterSpeed;


    private void SpawnHole()
    {
        float randomX = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        float randomZ = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);

        Instantiate(holePrefab, new Vector3(randomX, spawnArea.bounds.max.y + 0.01f, randomZ),
                                                        Quaternion.Euler(new Vector3(0, 90, 0)),
                                                        boat.transform);
    }

    private int GetHolesNumber()
    {
        return FindObjectsOfType<Hole>().Length;
    }

    void Update()
    {
        if (mustSpawn)
        {
            SpawnHole();
            mustSpawn = false;
        }

        if (GetHolesNumber() > 0)
        {
            water.transform.position += new Vector3(0, baseWaterSpeed * GetHolesNumber() * Time.deltaTime, 0);
        }
    }
}
