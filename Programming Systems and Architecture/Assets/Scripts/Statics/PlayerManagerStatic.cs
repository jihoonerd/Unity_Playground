using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = PlayerStatic.playerCount;
        Debug.Log("Num players: " + x.ToString());

        int returnUtil = UtilitiesStatic.Add(3, 5);
        Debug.Log("Return value from Util: " + returnUtil.ToString()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
