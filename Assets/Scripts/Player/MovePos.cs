using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class MovePos : MonoBehaviour
{
    Vector3 mov;
    public int speed = 10;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        mov = new Vector3(Input.GetAxis("Horizontal"),0f, Input.GetAxis("Vertical"));
        rb.MovePosition(transform.position + (mov * speed * Time.deltaTime));
    }


}
