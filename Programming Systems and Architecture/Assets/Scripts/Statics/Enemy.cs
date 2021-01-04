using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{
    //Static variables are shared across all instances of a class.
    public static int enemyCount = 0;

    public Enemy()
    //Be aware that constructor is a method whose name is the same as the name of its type.
    //Following is a constructor. 
    {
        //Increment the static variable to know how many objects
        //of this class has been created.
        enemyCount++;
    }
}
