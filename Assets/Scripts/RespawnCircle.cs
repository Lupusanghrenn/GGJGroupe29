using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnCircle : MonoBehaviour
{
    public float timeTimeToRespawn;

    private float time = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.GetChild(0).GetComponent<Image>().fillAmount = time / timeTimeToRespawn;
    }
}
