using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SmoothHealthBarView : HealthView
{
    [SerializeField] private float _smoothIndex;

    private Slider _slider;
    private Coroutine _changeValueCoroutine;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.minValue = _healther.MinHealth;
        _slider.maxValue = _healther.MaxHealth;
    }

    protected override void ShowHealth(float value)
    {
        if(_changeValueCoroutine != null)
            StopCoroutine(_changeValueCoroutine);

        _changeValueCoroutine = StartCoroutine(ChangeValue(value));
    }

    private IEnumerator ChangeValue(float targetValue)
    {
        while (_slider.value != targetValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, targetValue, _smoothIndex);

            yield return null;
        }
    }
}