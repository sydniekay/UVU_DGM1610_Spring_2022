using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20;
    public float rotateSpeed = 60;

    public GameObject health;

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
        transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
    }

}
