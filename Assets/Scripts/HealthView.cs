using UnityEngine;

public abstract class HealthView : MonoBehaviour
{
    [SerializeField] protected Healther _healther;

    protected void OnEnable()
    {
        _healther.HealthChanged += OnHealthChanged;
    }

    protected void OnDisable()
    {
        _healther.HealthChanged -= OnHealthChanged;
    }

    protected void OnHealthChanged(float currentHealth)
    {
        ShowHealth(currentHealth);
    }

    protected virtual void ShowHealth(float value) { }
}