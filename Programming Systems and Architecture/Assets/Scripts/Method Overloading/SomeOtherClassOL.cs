using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassOL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClassOL myClass = new SomeClassOL();

        Debug.Log(myClass.Add(1, 2));
        Debug.Log(myClass.Add("Add", "String"));
    }
}
