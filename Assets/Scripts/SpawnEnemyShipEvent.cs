using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyShipEvent : MonoBehaviour
{
    public Vector3 spawnPointLeft;
    public Vector3 spawnPointRight;

    public string direction;

    public EnemyShip enemyShip;
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
        // Spawn Left
        if (direction == "Right")
        {
            enemyShip = Instantiate(enemyShipPrefab, new Vector3(spawnPointLeft.x, spawnPointLeft.y + water.transform.position.y, spawnPointLeft.z), Quaternion.Euler(new Vector3(0, -90, 0)), water.transform).GetComponent<EnemyShip>();
            enemyShip.direction = "Right";
            enemyShip.spawnPointLeft = this.spawnPointLeft;
            enemyShip.spawnPointRight = this.spawnPointRight;
        }

        // Spawn Right
        if (direction == "Left")
        {
            enemyShip = Instantiate(enemyShipPrefab, new Vector3(spawnPointRight.x, spawnPointRight.y + water.transform.position.y, spawnPointRight.z), Quaternion.Euler(new Vector3(0, 90, 0)), water.transform).GetComponent<EnemyShip>();
            enemyShip.direction = "Left";
            enemyShip.spawnPointLeft = this.spawnPointLeft;
            enemyShip.spawnPointRight = this.spawnPointRight;
        }
    }
}
