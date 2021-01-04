using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties
{
    //Member variables can be referred to as fields.
    private int experience;
    public static int playerCount = 0;

    void Start()
    {
        playerCount++;
    }

    //Experience is a basic property
    public int Experience
    {
        get
        {
            //Some other code
            return experience;
        }
        set
        {
            //Some other code
            experience = value;
        }
    }

    //Level is a property that converts experience
    //points into the level of a player automatically
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    public int Health { get; set; }
}
