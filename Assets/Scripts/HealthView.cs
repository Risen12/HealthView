using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected void OnEnable()
    {
        Health.ValueChanged += OnHealthChanged;
    }

    protected void OnDisable()
    {
        Health.ValueChanged -= OnHealthChanged;
    }

    protected void OnHealthChanged(float currentHealth)
    {
        ShowHealth(currentHealth);
    }

    protected virtual void ShowHealth(float value) { }
}