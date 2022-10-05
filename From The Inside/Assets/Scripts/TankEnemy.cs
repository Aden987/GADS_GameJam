using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankEnemy : MonoBehaviour
{
    public float maxHealth;
    public  float currentHealth;
    int damage = 5;
    public Slider tankSlider;
    public GameObject tank;
    TankHealth pc;
    void Start()
    {
        pc = FindObjectOfType<TankHealth>();
        pc.currentHealth = pc.maxHealth;
        SetTankMaxHealth();
    }

     //Update is called once per frame
    void Update()
    {
        
    }

    public void SetTankHealth()
    {
        pc.currentHealth -= 10;
        tankSlider.value = pc.currentHealth;
        if (pc.currentHealth <= 0)
        {
           Destroy(tank);
        }
    }

    public void SetTankMaxHealth()
    {
        tankSlider.maxValue = pc.maxHealth;
        tankSlider.value = pc.maxHealth;
    }
}
