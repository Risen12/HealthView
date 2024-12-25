using Assets.Scripts.UI;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RestoreHealthButton : SimpleButton
{
    [SerializeField] private float _healthPointsToRestore;

    protected override void HandleClick()
    {
        Health.Restore(_healthPointsToRestore);    
    }
}