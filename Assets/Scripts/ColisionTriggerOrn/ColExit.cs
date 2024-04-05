using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionExit(Collision other){

        if(other.collider.tag == "Player"){

            Debug.Log("Collision Exit");

        }
    }
}
