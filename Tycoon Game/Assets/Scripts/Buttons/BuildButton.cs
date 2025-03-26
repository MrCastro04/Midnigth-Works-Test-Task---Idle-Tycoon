using System;
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
        }

        private void Start()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            _button.gameObject.SetActive(false);

            EventManager.RaisePlayerClickBuildButton();
        }
    }
}