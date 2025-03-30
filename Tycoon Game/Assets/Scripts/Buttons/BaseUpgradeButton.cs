using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
    public abstract class BaseUpgradeButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();

            _button.onClick.AddListener(OnClick);
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        protected abstract void OnClick();
    }
}