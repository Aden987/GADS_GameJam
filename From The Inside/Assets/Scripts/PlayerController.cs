using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private float acceleration;
    private float turn;
    [SerializeField] private float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        acceleration = Mathf.Lerp(acceleration, Input.GetAxisRaw("Vertical") * speed, 2.5f * Time.deltaTime);
        turn = Mathf.Lerp(turn, Input.GetAxisRaw("Horizontal") * speed, 2.5f * Time.deltaTime);
        transform.position += transform.forward * acceleration * Time.deltaTime;
        transform.position += transform.right * turn * Time.deltaTime;
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turn * turningStrength * Time.deltaTime * Input.GetAxisRaw("Vertical"), 0f));
    }
}
