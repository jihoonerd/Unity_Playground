using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class BadGuy : IComparable<BadGuy>
{
    public string name;
    public int power;

    public BadGuy(string newName, int newPower)
    {
        name = newName;
        power = newPower;
    }

    //THis method is required by the IComparable interface.
    public int CompareTo(BadGuy other)
    {
        if(other == null)
        {
            return 1;
        }
        return power - other.power;
    }
}