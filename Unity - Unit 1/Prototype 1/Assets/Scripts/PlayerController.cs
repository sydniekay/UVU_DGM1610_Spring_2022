using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Private variables
    // We're changing these to Serialized Fields
    // [SerializeField] allows the variable to be seen in the inspector in Unity while still remaining private 
    // protected is somewhere between public and private.

    [SerializeField] float speed;
    [SerializeField] float rpm;

    [SerializeField] private float horsePower = 0;
    [SerializeField] private const float turnSpeed = 50f;
    [SerializeField] private float horizontalInput;
    [SerializeField] float forwardInput;

    private Rigidbody playerRb;

    [SerializeField] GameObject centerOfMass;

    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;

    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

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

        if (IsOnGround())
        {
            playerRb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
            // Rotates the car based on horizontal input
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

            speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed: " + speed + "mph");

            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM: " + rpm);
        }

    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if(wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
