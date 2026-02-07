using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homing : MonoBehaviour
{
    [SerializeField] Transform target;
    private Rigidbody _rb;

    [SerializeField] float Speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = (target.position - _rb.position).normalized;
        Vector3 rotation = Vector3.Cross(transform.forward, direction);
        _rb.angularVelocity = new Vector3(rotation.x*3, rotation.y * 3,0);
        _rb.velocity = transform.forward * Speed;
    }
}
