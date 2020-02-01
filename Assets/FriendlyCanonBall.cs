using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyCanonBall : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
        transform.position += new Vector3(0, -5f * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<EnemyShip>() != null)
        {
            other.GetComponent<EnemyShip>().couler = true; // Coules batard
            Destroy(other.gameObject, 30f);
            Destroy(this.gameObject);
        }
    }
}
