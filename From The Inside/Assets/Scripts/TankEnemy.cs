using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankEnemy : MonoBehaviour
{
    int maxHealth = 50;
    int currentHealth;
    int damage = 5;
    public Slider tankSlider;
    void Start()
    {
        currentHealth = maxHealth;
        SetTankMaxHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTankHealth()
    {
        currentHealth -= 10;
        tankSlider.value = currentHealth;
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void SetTankMaxHealth()
    {
        tankSlider.maxValue = maxHealth;
        tankSlider.value = maxHealth;
    }
}
