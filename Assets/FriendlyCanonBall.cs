using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyCanonBall : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this, 30);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("bateau touche");
        Destroy(collision.gameObject);
        Destroy(this);
    }
}
