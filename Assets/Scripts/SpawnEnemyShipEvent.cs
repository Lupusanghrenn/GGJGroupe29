using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyShipEvent : MonoBehaviour
{
    public Vector3 spawnPointLeft;
    public Vector3 spawnPointRight;

    public GameObject enemyShipPrefab;

    public bool mustSpawn = false;

    private void SpawnEnemyShip()
    {
        int rand = Random.Range(0, 2);

        // Spawn Left
        if (rand == 0)
        {
            EnemyShip enemyShip = Instantiate(enemyShipPrefab, spawnPointLeft, Quaternion.identity).GetComponent<EnemyShip>();
            enemyShip.direction = "Right";
            enemyShip.spawnPointLeft = this.spawnPointLeft;
            enemyShip.spawnPointRight = this.spawnPointRight;
        }

        // Spawn Right
        if (rand == 1)
        {
            EnemyShip enemyShip = Instantiate(enemyShipPrefab, spawnPointRight, Quaternion.identity).GetComponent<EnemyShip>();
            enemyShip.direction = "Left";
            enemyShip.spawnPointLeft = this.spawnPointLeft;
            enemyShip.spawnPointRight = this.spawnPointRight;
        }
    }

    void Update()
    {
        if(mustSpawn)
        {
            SpawnEnemyShip();
            mustSpawn = false;
        }
    }
}
