using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timeLastSpawned = 0.0f;
    private float timeBetweenSpawns = 0.5f; 

    // Update is called once per frame
    void Update()
    {
        float timeDifference = Time.time - timeLastSpawned;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (timeLastSpawned == 0 || timeDifference >= timeBetweenSpawns)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeLastSpawned = Time.time;
            }
        } 
    }
}
