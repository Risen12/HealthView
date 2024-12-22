using System;
using UnityEngine;

public class Healther : MonoBehaviour
{
    public event Action<float> HealthChanged;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _minHealth;

    private float _health;

    public float MaxHealth => _maxHealth;
    public float MinHealth => _minHealth;

    private void Awake()
    {
        _health = _maxHealth;
        HealthChanged?.Invoke(_health);
    }

    public void ApplyDamage(float damage)
    {
        _health = Mathf.Clamp(_health - damage, _minHealth, _maxHealth);
        HealthChanged?.Invoke(_health);
    }

    public void Restore(float healthPoints)
    {
        _health = Mathf.Clamp(_health + healthPoints, _minHealth, _maxHealth);
        HealthChanged?.Invoke(_health);
    }
}