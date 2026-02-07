using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move4 : MonoBehaviour
{

    public float x = 0;
    public float z = 0;
    public float theta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x  = Mathf.Sin(theta);

        transform.position  = new Vector3(x,0.5f,z);

        theta += (2f * Mathf.PI / 360);
    }
}
