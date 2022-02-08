using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
   void Start ()
    {
        //this is a comment line. Below, there is some dot operator dummy code for practice. 

        /*Hello
         * this is a comment with multiple lines
         */

        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to hit the ground!");
        }
    }
}
