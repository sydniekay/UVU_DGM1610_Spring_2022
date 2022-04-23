using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTurret : MonoBehaviour
{
    public float mouseDepthInPixels;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookTowardMouse();
    }

    void LookTowardMouse()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, mouseDepthInPixels);
        Vector3 target = Camera.main.ScreenToWorldPoint(mousePos);
        transform.LookAt(target);

    }
}
