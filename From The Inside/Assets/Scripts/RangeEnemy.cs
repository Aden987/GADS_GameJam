using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangeEnemy : MonoBehaviour
{
    int maxHealth = 20;
    int currentHealth;
    public Slider rangeSlider;
    void Start()
    {
        currentHealth = maxHealth;
        SetRangeMaxHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRangeHealth()
    {
        currentHealth -= 10;
        rangeSlider.value = currentHealth;
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetRangeMaxHealth()
    {
        rangeSlider.maxValue = maxHealth;
        rangeSlider.value = maxHealth;
    }
}
