using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigController : MonoBehaviour
{
    private GameObject elbowL;
    private Rigidbody elbowLRigidbody;
    private GameObject handL;
    // Start is called before the first frame update
    void Start()
    {
        elbowL = GameObject.Find("elbowL");
        elbowLRigidbody = elbowL.GetComponent<Rigidbody>();
        elbowLRigidbody.AddForce(Vector3.right * 0.1f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
