using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public GameObject canonBallPrefab;

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
        GameObject canonBall = Instantiate(canonBallPrefab, this.transform.position, Quaternion.identity);

        StartCoroutine(SpawnHole());
        // Spawn un trou
    }

    IEnumerator SpawnHole()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Spawn Hole");
    }

    void Update()
    {
        if(direction == "Left")
        {
            this.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            
            if(this.transform.position.z <= spawnPointLeft.z)
            {
                direction = "Right";
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                this.transform.position = spawnPointLeft;
            }
        }
        if(direction == "Right")
        {
            this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);

            if (this.transform.position.z >= spawnPointRight.z)
            {
                direction = "Left";
                this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                this.transform.position = spawnPointRight;
            }
        }
    }
}
