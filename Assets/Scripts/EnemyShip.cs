﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public string direction = "";
    public float speed;

    public Vector3 spawnPointLeft;
    public Vector3 spawnPointRight;

    private void OnTriggerEnter(Collider other)
    {
        Shoot();
    }

    private void Shoot()
    {
        Debug.Log("Shoot");
        // Damage boat
        // Spawn un trou
    }

    void Update()
    {
        if(direction == "Left")
        {
            this.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            
            if(this.transform.position.z <= spawnPointLeft.z)
            {
                direction = "Right";
                this.transform.position = spawnPointLeft;
            }
        }
        if(direction == "Right")
        {
            this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);

            if (this.transform.position.z >= spawnPointRight.z)
            {
                direction = "Left";
                this.transform.position = spawnPointRight;
            }
        }
    }
}
