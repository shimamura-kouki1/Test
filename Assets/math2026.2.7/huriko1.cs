using UnityEngine;

public class huriko1 : MonoBehaviour
{
    GameObject core;

    Vector3 center1;

    Vector3 axis1;

    float angularVeloccity;
    float deltaAcceleration = 0.2f;
    float angularAcceleration;

    void Start()
    {
        core = GameObject.Find("Cube");
        center1 = core.transform.position;
        axis1 = core.transform.forward;

        this.transform.up = core.transform.position - this.transform.position;
    }

    private void FixedUpdate()
    {
        if(this.transform.position.x - core.transform.position.x>0f)
        {
            angularAcceleration = -deltaAcceleration;
        }
        else
        {
            angularAcceleration = deltaAcceleration;
        }
        angularVeloccity += angularAcceleration;
        transform.RotateAround(center1, axis1, angularVeloccity);
    }
}
