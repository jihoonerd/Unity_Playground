using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassGen : MonoBehaviour
{
    void Start()
    {
        SomeClassGen<int> myClass = new SomeClassGen<int>();
        Debug.Log(myClass.GenericMethod<int>(5));
        myClass.UpdateItem(10);
    }
}
