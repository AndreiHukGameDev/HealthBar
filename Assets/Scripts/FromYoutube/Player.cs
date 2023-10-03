using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Target
{
    public override void TakeDamage(int damage)
    {
        throw new System.NotImplementedException();
    }

    protected override void Start()
    {
        base.Start();
    }
}
