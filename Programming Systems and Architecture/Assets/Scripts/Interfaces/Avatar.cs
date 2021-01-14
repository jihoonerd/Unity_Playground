using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
{
    public void Kill()
    {
        //Do something
    }

    public void Damage(float damageTaken)
    {
        //Do something
    }
}
