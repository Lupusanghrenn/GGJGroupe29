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

    public Vector3 spawnPointLeft;
    public Vector3 spawnPointRight;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(ShootDelay());
    }

    private void Shoot()
    {
        GameObject canonBall = Instantiate(canonBallPrefab, new Vector3(this.transform.position.x, this.transform.position.y + 10f, this.transform.position.z),
                                                                        Quaternion.identity);
        Debug.Log("BoatShoot");
        StartCoroutine(CanonBallHit());
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(25f);
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
        }
        else
        {
            this.transform.position -= new Vector3(0, 5 * Time.deltaTime, 0);
            this.transform.eulerAngles += new Vector3(0, 0, 5 * Time.deltaTime);
        }

    }
}
