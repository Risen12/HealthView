using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _maxValue;
    [SerializeField] private float _minValue;

    private float _health;

    public event Action<float> ValueChanged;

    public float MaxHealth => _maxValue;
    public float MinHealth => _minValue;

    private void Start()
    {
        _health = _maxValue;
        ValueChanged?.Invoke(_health);
    }

    public void ApplyDamage(float damage)
    {
        _health = Mathf.Clamp(_health - damage, _minValue, _maxValue);
        ValueChanged?.Invoke(_health);
    }

    public void Restore(float healthPoints)
    {
        _health = Mathf.Clamp(_health + healthPoints, _minValue, _maxValue);
        ValueChanged?.Invoke(_health);
    }
}