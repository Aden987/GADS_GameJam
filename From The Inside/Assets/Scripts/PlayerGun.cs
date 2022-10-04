using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private float range = 100f;
    public Camera playerCam;
    public ParticleSystem muzzleFlash; 
    void Start()
    {
        
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
        if (hit.collider.gameObject.tag == "enemy")
        {
            Destroy(hit.collider.gameObject);
        }
        muzzleFlash.Play();
        Debug.Log("hit");
        
    }
}
