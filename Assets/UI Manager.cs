using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text healthText;
    
    public void UpdateHealthText(float newHealth)
    {
        int health = (int)newHealth;
        string stringHealth = health.ToString();
        healthText.text = stringHealth;
    }
}
