using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 9.0f;
    private float depthBound = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Enemy out of bounds, destroyed
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z > depthBound)
        {
            Destroy(gameObject);
        }
    }
}
