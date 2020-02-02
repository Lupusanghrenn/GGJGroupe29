using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItenInHandScript : MonoBehaviour
{
    public Sprite bucketEmptySprite;
    public Sprite bucketFullSprite;
    public Sprite canonBallSprite;
    public Sprite plankSprite;

    public void UpdateItemInHand(string itemInHand)
    {
        if (itemInHand == "EmptyBucket")
            transform.GetChild(0).GetComponent<Image>().sprite = bucketEmptySprite;
        if (itemInHand == "FullBucket")
            transform.GetChild(0).GetComponent<Image>().sprite = bucketFullSprite;
        if (itemInHand == "WoodPlank")
            transform.GetChild(0).GetComponent<Image>().sprite = plankSprite;
        if (itemInHand == "CanonBall")
            transform.GetChild(0).GetComponent<Image>().sprite = canonBallSprite;
        if (itemInHand == "None")
            transform.GetChild(0).GetComponent<Image>().sprite = null;
    }

    private void Update()
    {
        transform.LookAt(transform.position + Vector3.forward);
    }
}
