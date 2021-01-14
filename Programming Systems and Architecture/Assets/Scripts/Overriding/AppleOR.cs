using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleOR : FruitOR
{
    public AppleOR()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    //These methods overrides and therefore can override any virtual methods in the parent class.
    public override void Chop()
    {
        base.Chop();
        Debug.Log("The apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am an apple.");
    }
}
