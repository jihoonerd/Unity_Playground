using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameProperties : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerProperties myPlayer = new PlayerProperties();

        //Properties can be used just like variables
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
        Debug.Log(x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
