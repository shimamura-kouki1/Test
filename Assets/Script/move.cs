using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject obj;

    public int n = 5;
    public float r = 3;
    float dig;
    float theta = 0;
    float x;
    float y;
    float z;
    // Start is called before the first frame update
    void Start()
    {
        dig = 2f * Mathf.PI/n;

        for(int i=0;i<n;i++)
        {
            z = r * Mathf.Sin(theta);
            x = r * Mathf.Cos(theta);
            y = 1;
            //
            Instantiate(obj, new Vector3(x, y, z), Quaternion.identity);
            theta += dig;
        }
    }
}
