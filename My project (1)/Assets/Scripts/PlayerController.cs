using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is where we get user input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward*Time.deltaTime*speed* forwardInput);
        //control the vehicle turn round
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalInput* turnSpeed);
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * turnSpeed);
    }
}
