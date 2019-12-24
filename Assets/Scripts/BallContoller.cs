using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallContoller : MonoBehaviour
{
    void Update()
    {
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        int rotationSpeed = 45;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddTorque(-Vector3.left * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddTorque(Vector3.left * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(Vector3.forward * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(-Vector3.forward * rotationSpeed);
        }
        if (transform.position.y < -3)
        {
            Application.LoadLevel(0);
        }
    }
}



