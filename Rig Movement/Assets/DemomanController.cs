using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemomanController : MonoBehaviour
{
    public GameObject rigControl;
    public Vector3 leftFootChange;
    public Vector3 rightFootChange;
    public Vector3 leftHandChange;
    public Vector3 rightHandChange;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rigControl.transform.GetChild(2).position += leftFootChange;
        rigControl.transform.GetChild(3).position += rightFootChange;
        rigControl.transform.GetChild(4).position += leftHandChange;
        rigControl.transform.GetChild(5).position += rightHandChange;
    }
}
