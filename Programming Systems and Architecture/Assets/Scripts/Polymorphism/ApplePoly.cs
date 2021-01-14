using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePoly : FruitPoly
{
    public ApplePoly()
    {
        Debug.Log("1st Apple constructor called");
    }

    public new void Chop()
    {
        Debug.Log("The apple has been chopped.");
    }

    public new void SayHello()
    {
        Debug.Log("Hello, I am an apple.");
    }
}
