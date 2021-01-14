using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour
{
    delegate void MyDelegate(int num);
    MyDelegate myDelegate;
    // Start is called before the first frame update
    void Start()
    {
        myDelegate = PrintNum;
        myDelegate(50);

        myDelegate = DoubleNum;
        myDelegate(50);
    }

    void PrintNum(int num)
    {
        print("Print num: " + num);
    }

    void DoubleNum(int num)
    {
        print("Double num: " + num * 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
