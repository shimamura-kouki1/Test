using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class math3_player : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        var rotate = Input.GetAxisRaw("Horizontal");
        var going = Input.GetAxisRaw("Vertical");

        transform.position += transform.forward * going * 0.1f;
        transform.Rotate(0, rotate * 2f, 0);
    }
}

static public class Data
{
    public static float r = 9.00f;//éŒï”
    public static float Alpha = 0.53f;//äpìxÅiRADÅj
    public static float cosA = Mathf.Cos(Alpha);//
    public static float range = r * cosA;
    public static float height = r*Mathf.Sin(Alpha);
}

