using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClassEM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This is useful when you don't have access to a class, but needs additional functionality from it.
        transform.ResetTransformation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
