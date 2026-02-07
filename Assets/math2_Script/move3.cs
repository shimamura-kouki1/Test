using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move3 : MonoBehaviour
{

    float theta = 0;
    float phi = 0;
    public float x = 0;
    public float y = 0;
    public float z = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        z = 5f * Mathf.Sin(theta) * Mathf.Sin(phi);
        x = 5f * Mathf.Sin(theta) * Mathf.Cos(phi);
        y = 5f * Mathf.Sin(theta);

        transform.position = new Vector3(x, y+6f, z);

        theta += (0.2f * Mathf.PI / 360f);
        phi+= (4f*Mathf.PI/360f);
    }
}
