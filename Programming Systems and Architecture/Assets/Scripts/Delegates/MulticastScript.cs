using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MulticastScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;
    // Start is called before the first frame update
    void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;
        if(myMultiDelegate != null)
        {
            myMultiDelegate();
        }
    }

    void PowerUp()
    {
        print("Orb is powering up!");
    }

    void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
