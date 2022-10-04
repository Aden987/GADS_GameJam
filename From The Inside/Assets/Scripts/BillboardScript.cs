using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardScript : MonoBehaviour
{
    public Transform mainCam;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(transform.position + mainCam.forward);
    }
}
