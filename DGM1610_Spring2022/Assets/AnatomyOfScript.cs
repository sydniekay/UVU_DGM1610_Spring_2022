using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    //This is just laying out some basics for what scripts look like for C# in Unity.
    
    //Use this for initialization
    void Start ()
    {
        //Creating a variable with a string datatype
        public string myName;

        //Controlling a GameObject with a function.
        Debug.Log("I am alive! My name is" + myName);

    }

    //Update is called once per frame
    void Update ()
    {

    }



    //This is an example of instantiation

    // Reference to the Prefab. Drag a Prefab into this field in the Inspector. 
    public GameObject myPrefab;
    
    // This script will simnply instantiate the Prefab when the game starts.  
    void Start ()
    {
         //Instantiate at position (0, 0, 0) and zero rotation.
         Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion, identity);

    }

}