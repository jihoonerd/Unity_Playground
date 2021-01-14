using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMH : HumanoidMH
{
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
