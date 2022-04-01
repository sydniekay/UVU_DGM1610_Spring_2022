using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /* Goal for player controls:
     * Player moves left and right with arrow keys
     * Player has bounds of -7 and 7 to prevent them from falling off screen
     * Player sprays bugs that go from the bottom to the top of the screen
     * Player sprays when spacebar is pressed (single stream? multi stream?)
     * Must have small delay between sprays
     */

    private float speed = 7f;
    private float xBounds = 7.0f;
    private Rigidbody playerRb;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        PlayerBounds();
    }

    // Moves the player based on arrow key input
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }

    // Giving bounds to player's x axis movement
    void PlayerBounds()
    {
        if (transform.position.x > xBounds)
        {
            transform.position = new Vector3(xBounds, transform.position.y, transform.position.z);
            playerRb.velocity = Vector3.zero;
        }
        else if (transform.position.x < -xBounds)
        {
            transform.position = new Vector3(-xBounds, transform.position.y, transform.position.z);
            playerRb.velocity = Vector3.zero;
        }
    }
}
