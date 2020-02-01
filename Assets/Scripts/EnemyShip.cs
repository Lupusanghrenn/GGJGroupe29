using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public GameObject canonBallPrefab;

    private GameObject water;
    public bool couler = false;

    private GameManager gameManager;

    public string direction = "";
    public float speed;

    private float basePositionY;
    private float baseWaterPositionY;

    public Vector3 spawnPointLeft;
    public Vector3 spawnPointRight;

    private void Start()
    {
        basePositionY = this.transform.position.y;
        water = GameObject.FindGameObjectWithTag("Water");
        baseWaterPositionY = water.transform.position.y;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(ShootDelay());
    }

    private void Shoot()
    {
        GameObject canonBall = Instantiate(canonBallPrefab, this.transform.position, Quaternion.identity);
        StartCoroutine(CanonBallHit());
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(27f);
        Shoot();
    }

    IEnumerator CanonBallHit()
    {
        yield return new WaitForSeconds(1f);
        //gameManager.life -= 10f;
        // Spawn Hole
    }

    void Update()
    {
        if(!couler)
        {
            if (direction == "Left")
            {
                this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);

                if (this.transform.position.x <= spawnPointLeft.x)
                {
                    //direction = "Right";
                    //this.transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
                    //this.transform.position = spawnPointLeft;
                    Destroy(this.gameObject);
                }
            }
            if (direction == "Right")
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
            this.transform.position = new Vector3(this.transform.position.x,
                water.transform.position.y + basePositionY - baseWaterPositionY,
                this.transform.position.z);
        }
        else
        {
            this.transform.position -= new Vector3(0, 5 * Time.deltaTime, 0);
            this.transform.eulerAngles += new Vector3(0, 0, 5 * Time.deltaTime);
        }

    }
}
