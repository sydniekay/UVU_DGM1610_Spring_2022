using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody playerRb;
    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;

    public float floatForce = 10;
    private float gravityModifier = 1.5f;
    private float maxHeight = 16;
    private float minHeight = 1;
    public float ceilingForce = -1;
    public float groundForce = 1;
    public bool isInAir = true;
    public bool gameOver;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {
            playerRb.AddForce(Vector3.up * floatForce, ForceMode.Impulse);
        }

        // Player "hits" the ceiling and bounces off of it, so it isn't floating in space
        if (playerRb.position.y > maxHeight)
        {
            playerRb.transform.position = new Vector3(-3, 16, 0);
            playerRb.AddForce(Vector3.up * ceilingForce, ForceMode.Impulse);
        }

        // Player bounces off the ground
        if (playerRb.position.y < minHeight)
        {
            playerRb.transform.position = new Vector3(-3, 1, 0);
            playerRb.AddForce(Vector3.up * groundForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

    }

}
