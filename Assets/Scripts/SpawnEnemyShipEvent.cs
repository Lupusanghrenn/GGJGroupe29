﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyShipEvent : MonoBehaviour
{
    public Vector3 spawnPointLeft;
    public Vector3 spawnPointRight;

    private GameObject water;
    public GameObject enemyShipPrefab;

    private void Start()
    {
        water = GameObject.FindGameObjectWithTag("Water");
        SpawnEnemyShip();
        Destroy(this.gameObject);
    }

    private void SpawnEnemyShip()
    {
        int rand = Random.Range(0, 2);

        // Spawn Left
        if (rand == 0)
        {
            EnemyShip enemyShip = Instantiate(enemyShipPrefab, spawnPointLeft, Quaternion.Euler(new Vector3(0, -90, 0)), water.transform).GetComponent<EnemyShip>();
            enemyShip.direction = "Right";
            enemyShip.spawnPointLeft = this.spawnPointLeft;
            enemyShip.spawnPointRight = this.spawnPointRight;
        }

        // Spawn Right
        if (rand == 1)
        {
            EnemyShip enemyShip = Instantiate(enemyShipPrefab, spawnPointRight, Quaternion.Euler(new Vector3(0, 90, 0)), water.transform).GetComponent<EnemyShip>();
            enemyShip.direction = "Left";
            enemyShip.spawnPointLeft = this.spawnPointLeft;
            enemyShip.spawnPointRight = this.spawnPointRight;
        }
    }
}
