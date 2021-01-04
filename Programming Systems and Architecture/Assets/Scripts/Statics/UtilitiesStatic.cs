using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilitiesStatic
{
    //A static method can be invoked without an object
    //of a class. note that static methods cannot access
    //non-static member variables.
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
}
