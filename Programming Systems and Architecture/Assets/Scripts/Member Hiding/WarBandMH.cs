using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBandMH : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HumanoidMH human = new HumanoidMH();
        HumanoidMH enemy = new EnemyMH();
        HumanoidMH orc = new OrcMH();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
