using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float rotate;

    // Update is called once per frame
    void Update()
    {
        // Move forward at x speed
        //transform.Translate();

        float driveInput = Input.GetAxis("Vertical");
        float turnInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed
            * Time.deltaTime * driveInput);

        transform.Rotate(Vector3.up, rotate 
            * Time.deltaTime * turnInput);
    }
}
