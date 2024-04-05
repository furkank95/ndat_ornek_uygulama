using System.Collections;
using System.Collections.Generic;
//using System.Numerics;        vector3'te hata verdi
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TranslateMov : MonoBehaviour
{

    public int speed = 10;
    // Start is called before the first frame update
    Vector3 mov;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        mov = new Vector3(Input.GetAxis("Horizontal"),0f, Input.GetAxis("Vertical"));
        transform.Translate(mov * speed * Time.deltaTime);
    }
    
}
