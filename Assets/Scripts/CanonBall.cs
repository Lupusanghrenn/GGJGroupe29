using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonBall : MonoBehaviour
{
    private void Start()
    {
        Destroy(this.gameObject, 3f);
    }
    void Update()
    {
        this.transform.position += new Vector3(35 * Time.deltaTime, 0, 0);
    }
}
