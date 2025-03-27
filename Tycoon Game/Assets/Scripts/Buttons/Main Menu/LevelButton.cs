using Core;
using UnityEngine;
using UnityEngine.UI;

namespace Buttons.Main_Menu
{
    public class LevelButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();

            _button.onClick.AddListener(EventManager.RaiseOnPlayerClickSelectLevelButton);
        }
    }
}