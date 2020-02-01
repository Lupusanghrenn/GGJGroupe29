using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealthBar : MonoBehaviour
{
    public void UpdateHealthBar(float currentHealth, float maxHealth)
    {
        transform.Find("fill").GetComponent<Image>().fillAmount = currentHealth / maxHealth;
    }

    private void Update()
    {
        transform.LookAt(transform.position + Vector3.forward);
    }
}
