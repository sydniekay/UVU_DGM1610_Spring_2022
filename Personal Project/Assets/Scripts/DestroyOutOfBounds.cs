using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xBounds = 18;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyGameObject();
    }
    private void DestroyGameObject()
    {

        if (gameObject.transform.position.x > xBounds || gameObject.transform.position.x < -xBounds)
        {
            Destroy(gameObject);
        }
    }
}
