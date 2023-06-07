using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpStats : MonoBehaviour
{
    Image HPbar;
    float maxHealth = 100f;
    public static float health;

    void Start()
    {
        HPbar = GetComponent<Image>();
        health = maxHealth;
    }

    void Update()
    {
        HPbar.fillAmount = health / maxHealth;
    }
}
