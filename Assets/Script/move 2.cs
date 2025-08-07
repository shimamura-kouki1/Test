using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    float x = 0;
    float z = 0;
    float theta = 0;

    
    // Update is called once per frame
    void Update()
    {

        x = 5f*Mathf.Sin(theta);
        //x =  Mathf.Sin(20f*theta);
        z = 5f*Mathf.Cos(theta);
        transform.position = new Vector3(x, 0.5f, z);

        theta += (2f*Mathf.PI/360 );
    }
}
