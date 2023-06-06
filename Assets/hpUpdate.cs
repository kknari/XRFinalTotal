using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpUpdate : MonoBehaviour
{
    Image HPImage;
    float maxHealth = 100f;
    public static float health;

    void Start()
    {
        HPImage = GetComponent<Image>();
        health = maxHealth;
    }

    void Update()
    {
        HPImage.fillAmount = health / maxHealth;
    }
}
