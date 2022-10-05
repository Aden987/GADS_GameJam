using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangeEnemy : MonoBehaviour
{
    int maxHealth = 20;
    int currentHealth;
    public Slider rangeSlider;
    public GameObject range;
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
            if (gameObject != null)
            {
                Destroy(range);
            }
        }
    }

    public void SetRangeMaxHealth()
    {
        rangeSlider.maxValue = maxHealth;
        rangeSlider.value = maxHealth;
    }
}
