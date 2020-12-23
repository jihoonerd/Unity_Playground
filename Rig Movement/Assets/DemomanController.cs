using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemomanController : MonoBehaviour
{
    public GameObject rigControl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rigControl.transform.GetChild(3));
        Debug.Log(rigControl.transform.GetChild(3).position);
        rigControl.transform.GetChild(2).position += new Vector3(0, 0, 0.01f);
        rigControl.transform.GetChild(3).position += new Vector3(0, 0, 0.01f);
        rigControl.transform.GetChild(4).position += new Vector3(0, 0.01f, 0);
        rigControl.transform.GetChild(5).position += new Vector3(0, 0.01f, 0);
    }
}
