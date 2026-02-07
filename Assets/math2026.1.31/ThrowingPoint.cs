using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingPoint : MonoBehaviour
{
    [SerializeField] private float _speed;
    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.W)) move += Vector3.forward;
        if (Input.GetKey(KeyCode.A)) move += Vector3.right;
        if (Input.GetKey(KeyCode.S)) move += Vector3.back;
        if (Input.GetKey(KeyCode.D)) move += Vector3.left;

        transform.Translate( move.normalized * _speed *Time.deltaTime) ;

    }

}
