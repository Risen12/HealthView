using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ApplyDamageButton : MonoBehaviour
{
    [SerializeField] private Healther _healther;
    [SerializeField] private float _damagePoints;

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        _healther.ApplyDamage(_damagePoints);
    }
}