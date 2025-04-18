using Core;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class CloseWindowButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();

            _button.onClick.AddListener(EventManager.RaiseOnPlayerClickCloseWindowButton);
        }
    }
}
