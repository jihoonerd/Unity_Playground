using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatic
{
    // Start is called before the first frame update
    void Start()
    {
        EnemyStatic enemy1 = new EnemyStatic();
        EnemyStatic enemy2 = new EnemyStatic();
        EnemyStatic enemy3 = new EnemyStatic();

        //You can access a staic variable by using the class name
        //and the dot operator
        int x = EnemyStatic.enemyCount;      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
