using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladOR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AppleOR myApple = new AppleOR();
        myApple.SayHello();
        myApple.Chop();

        FruitOR myFruit = new AppleOR();
        myFruit.SayHello();
        myFruit.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
