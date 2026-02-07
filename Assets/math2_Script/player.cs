using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    private Rigidbody rd = default;

    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var hor = Input.GetAxisRaw("Horizontal");
        var ver = Input.GetAxisRaw("Vertical");

        rd.AddForce(new Vector3(hor, 0f, ver)*speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rd.velocity = new Vector3(0,7,0);
        }
    }
}
