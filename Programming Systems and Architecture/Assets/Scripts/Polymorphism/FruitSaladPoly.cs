using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladPoly : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FruitPoly myFruit = new ApplePoly();
        myFruit.SayHello();
        myFruit.Chop();

        ApplePoly myApple = (ApplePoly)myFruit;
        myApple.SayHello();
        myApple.Chop();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
