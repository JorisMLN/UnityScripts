using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private Variables
    private float speed = 12.0f;
    private float turnSpeed = 25.0f;
    private float horizontalImput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get player input
        horizontalImput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // we'll move the vehicule forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // turn the vehicule
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalImput);
    }
}
