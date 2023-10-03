using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Target : MonoBehaviour
{
    [Header("Health")]

    public int maxHealth = 3;
    protected int _currentHealt;
    protected virtual void Start()
    {
        _currentHealt = maxHealth;
    }

    public abstract void TakeDamage(int damage);
}
