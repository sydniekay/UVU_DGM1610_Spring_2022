using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20;
    public float rotateSpeed = 60;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTarget();
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    void MoveTarget()
    {
        float direction = getDirection(gameObject.transform.localScale.z);
        transform.Translate(Vector3.left * Time.deltaTime * speed * direction, Space.World);
    }

    private float getDirection(float scaleFactor)
    {
        if (scaleFactor < 0)
        {
            return -1;
        }
        return 1;
    }

}
