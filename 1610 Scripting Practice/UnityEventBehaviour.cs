using System;
using UnityEngine;
using UnityEngine.Events;

public class ExampleClass : MonoBehavior
{
    // Practice script for using Unity Events

    // Following along with SpeedTutor on how he 
    [Serialized Field] private UnityEvent myTrigger;

	private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myTrigger.Invoke();
        }
    }
    /* Now when you open Unity, this script inside the inspector should have a list you can add to.
     * Inside that list you can take functions from other scripts and add them to different objects
     * without having to add the entire script to that object. 
    */





    // Notes from Unity Scripting API
    // This is just an example of some code for what you could do with implementing Unity Events

    UnityEvent myEvent;

    void Start()
    {
        if (myEvent == null)
        {
            myEvent = new UnityEvent();

            myEvent.AddListener(Ping);
        }
    }

    void Update()
    {
        if (Input.anyKeyDown && myEvent != null)
        {
            myEvent.Invoke();
        }
    }

    void Ping()
    {
        Debug.Log("Ping");
    }

    // Some of my own functions that I might want to use a unity event for.

    void OnTriggerEnter()
    {
        if (OnMouse.Down == true)
        {
            Destroy.GameObject();
        }
    }

    void DestroyOutOfBounds()
    {
        if (GameObject.transform.position.x < leftBound || > rightBound)
        {
            Destroy.GameObject();
        }
    }

    /* Because I'm writing this script from scratch in my IDE vs. creating one in Unity,
     * a lot of the syntax is missing, and I'm writing a lot of this from memory.
     * It likely wouldn't run, but the concepts should be the same. 
     */
}
