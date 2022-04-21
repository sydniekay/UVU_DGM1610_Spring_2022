using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    // We're changing these to Serialized Fields
    // [SerializeField] allows the variable to be seen in the inspector in Unity while still remaining private 
    // protected is somewhere between public and private.

    //[SerializeField] private protected float speed = 20.0f;

    [SerializeField] private float horsePower = 0;
    [SerializeField] private const float turnSpeed = 50f;
    [SerializeField] private float horizontalInput;
    [SerializeField] float forwardInput;

    private Rigidbody playerRb;

    [SerializeField] GameObject centerOfMass;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves the car forward based on vertical input
        // transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        playerRb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
