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
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
        gameManager.currentLife -= 10f;
        Debug.Log("Boat life : " + gameManager.currentLife);
        // Spawn Hole
    }

    void Update()
    {
        if(direction == "Left")
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            
            if(this.transform.position.x <= spawnPointLeft.x)
            {
                //direction = "Right";
                //this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                //this.transform.position = spawnPointLeft;
                Destroy(this.gameObject);
            }
        }
        if(direction == "Right")
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

            if (this.transform.position.x >= spawnPointRight.x)
            {
                //direction = "Left";
                //this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                //this.transform.position = spawnPointRight;
                Destroy(this.gameObject);
            }
        }
    }
}
