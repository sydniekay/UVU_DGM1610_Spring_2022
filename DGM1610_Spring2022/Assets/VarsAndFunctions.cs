using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarsAndFunctions : MonoBehaviour
{

    int myInt = 5;


    void Start()
    {
        myInt = MulltiplyByTwo(myInt);
        Debug.Log(myInt);

    }


    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;

    }

}
