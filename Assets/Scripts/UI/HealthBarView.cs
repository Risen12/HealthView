using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBarView : HealthView
{
    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.minValue = _healther.MinHealth;
        _slider.maxValue = _healther.MaxHealth;
    }

    protected override void ShowHealth(float value)
    {
        _slider.value = Mathf.Clamp(value, _healther.MinHealth, _healther.MaxHealth);
    }
}