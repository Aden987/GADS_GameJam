using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MelleeEnemy : MonoBehaviour
{
    int maxHealth = 30;
    int currentHealth;
    int damage = 10;
    public Slider meleeSlider;
    public GameObject melee;

    void Start()
    {
        currentHealth = maxHealth;
        SetMeleeMaxHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetMeleeHealth()
    {
        currentHealth -= 10;
        meleeSlider.value = currentHealth;
        if (currentHealth <= 0)
        {
            if (gameObject != null)
            {
                Destroy(melee);
            }
            //Destroy(this.gameObject);
        }
    }

    public void SetMeleeMaxHealth()
    {
        meleeSlider.maxValue = maxHealth;
        meleeSlider.value = maxHealth;
    }
}
