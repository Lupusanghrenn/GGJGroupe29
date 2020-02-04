using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyCanonBall : MonoBehaviour
{
    public float speed;
    private GameObject water;

    // Start is called before the first frame update
    void Start()
    {
        water = GameObject.FindGameObjectWithTag("Water");
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    { // WATER = 0 -> X = -5
      // WATER = 13 -> -5 + x*13 = 0
        transform.position += transform.forward * speed * Time.deltaTime;
        transform.position += new Vector3(0, (-5f + 0.4f * water.transform.position.y) * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<EnemyShip>() != null)
        {
            other.GetComponent<EnemyShip>().couler = true; // Coules batard
            Destroy(other.gameObject, 30f);
            Destroy(this.gameObject);
        }
    }
}
