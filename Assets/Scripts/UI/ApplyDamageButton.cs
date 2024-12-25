using Assets.Scripts.UI;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ApplyDamageButton : SimpleButton
{
    [SerializeField] private float _damagePoints;

    protected override void HandleClick()
    {
        Health.ApplyDamage(_damagePoints);
    }
}