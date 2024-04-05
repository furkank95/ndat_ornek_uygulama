using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float moveSpeed;
    private Rigidbody rb;
    [SerializeField] private float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(  Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, Input.GetAxis("Vertical") * moveSpeed );
    
        if(Input.GetButtonDown("Jump")){

            rb.velocity =  new Vector3 (rb.velocity.x, jumpForce, rb.velocity.z);

        }


        if(Input.GetKeyDown(KeyCode.Q)){


            GameManager.Instance.SpawnCoin();
        }

        if(transform.position.y < 0 ){
            
            GameManager.Instance.IsAlive = false;
            Destroy(gameObject);
            GameManager.Instance.LoadScene("SampleScene");
        }
    
    }



}
