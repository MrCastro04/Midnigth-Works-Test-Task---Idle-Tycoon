
using Core;
using UnityEngine;
using UnityEngine.UI;

namespace Buttons
{
    public class BuildButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();

            _button.onClick.AddListener(EventManager.RaisePlayerClickBuildButton);
        }
    }
}