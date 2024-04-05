using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAddForceMovement : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3 (Input.GetAxis("Horizontal"),rb.velocity.y, Input.GetAxis("Vertical") );
        rb.AddForce(movement * speed);
    }
}
