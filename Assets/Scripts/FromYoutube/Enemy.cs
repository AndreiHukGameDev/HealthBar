using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Target
{
    [SerializeField] private HealthBar _healthBar;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Float")
        {
            return;
        }
        TakeDamage(1);
        Debug.Log("Hit!");
    }
    protected override void Start()
    {
        base.Start();
        _healthBar.SetHealthValue(_currentHealt, maxHealth);

    }
    public override void TakeDamage(int damage)
    {
        _currentHealt -= damage;
        _healthBar.SetHealthValue(_currentHealt, maxHealth);
        if (_currentHealt <= 0)
        {
            Destroy(gameObject);
        }
    }
}
