using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    [RequireComponent(typeof(Button))]
    public class SimpleButton : MonoBehaviour
    {
        [SerializeField] protected Health Health;

        protected Button Button;

        protected void Awake()
        {
            Button = GetComponent<Button>();
        }

        protected void OnEnable()
        {
            Button.onClick.AddListener(HandleClick);        
        }

        protected void OnDisable()
        {
            Button.onClick.RemoveListener(HandleClick);
        }

        protected virtual void HandleClick() { }
    }
}