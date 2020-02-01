using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public GameObject canonBallPrefab;

    private GameManager gameManager;

    public string direction = "";
    public float speed;

    public Vector3 spawnPointLeft;
    public Vector3 spawnPointRight;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Shoot();
    }

    private void Shoot()
    {
        GameObject canonBall = Instantiate(canonBallPrefab, this.transform.position, Quaternion.identity);

        StartCoroutine(CanonBallHit());
    }

    IEnumerator CanonBallHit()
    {
        yield return new WaitForSeconds(1f);
        gameManager.life -= 10f;
        Debug.Log("Boat life : " + gameManager.life);
        // Spawn Hole
    }

    void Update()
    {
        if(direction == "Left")
        {
            this.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            
            if(this.transform.position.z <= spawnPointLeft.z)
            {
                //direction = "Right";
                //this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                //this.transform.position = spawnPointLeft;
                Destroy(this.gameObject);
            }
        }
        if(direction == "Right")
        {
            this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);

            if (this.transform.position.z >= spawnPointRight.z)
            {
                //direction = "Left";
                //this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                //this.transform.position = spawnPointRight;
                Destroy(this.gameObject);
            }
        }
    }
}
