using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthSlider;
    public Slider shieldSlider;

    public void SetShield(int shield)
    {
        shieldSlider.value = shield;
    }

    public void SetMaxShield(int maxShield)
    {
        shieldSlider.maxValue = maxShield;
        shieldSlider.value = maxShield;
    }
    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }

    public void SetMaxHealth(int maxHealth)
    {
        healthSlider.maxValue = maxHealth;
        healthSlider.value = maxHealth;
    }
}
