using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float bottomBound = -10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the player's view in a game, remove that object
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }   
        else if (transform.position.z < bottomBound)
        {
            // If an object passes the player, then it get's destroyed and "Game Over" appears
            Debug.Log("Game Over!");
            Destroy (gameObject);
        }

    }
}
