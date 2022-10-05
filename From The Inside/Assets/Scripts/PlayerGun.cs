using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private float range = 100f;
    public Camera playerCam;
    public ParticleSystem muzzleFlash;
    public int maxHealth = 50;
    public int currentHealth;
    public int maxShield = 50;
    public int currentShield;
    
    PlayerHealth health;
    MelleeEnemy melee;
    TankEnemy tank;
    RangeEnemy lightE;
    void Start()
    {
        health = FindObjectOfType<PlayerHealth>();
        melee = FindObjectOfType<MelleeEnemy>();
        tank = FindObjectOfType<TankEnemy>();
        lightE = FindObjectOfType<RangeEnemy>();
        currentHealth = maxHealth;
        currentShield = maxShield;
        health.SetMaxHealth(maxHealth);
        health.SetMaxShield(maxShield);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, range);
        muzzleFlash.Play();
        if (hit.collider.gameObject.tag == "melee")
        {
            melee.SetMeleeHealth();
        }
        if (hit.collider.gameObject.tag == "tank")
        {
            tank.SetTankHealth();
        }
        if (hit.collider.gameObject.tag == "range")
        {
            lightE.SetRangeHealth();
        }
        /*else
        {
            if (currentShield > 0)
            {
                currentShield -= 10;
                health.SetShield(currentShield);
            }
            else
            {
                currentHealth -= 10;
                health.SetHealth(currentHealth);
            }
        }*/
        //muzzleFlash.Play();
        Debug.Log("hit");
        
    }
}
