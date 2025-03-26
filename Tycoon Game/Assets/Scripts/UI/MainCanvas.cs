using System;
using Buttons;
using Core;
using UnityEngine;

namespace UI
{
    public class MainCanvas : MonoBehaviour
    {
        private BuildButton _buttonBuildButton;

        private void Awake()
        {
            _buttonBuildButton = GetComponentInChildren<BuildButton>();
        }

        private void OnEnable()
        {
            EventManager.OnPlayerBuildDepartment += HandleOnPlayerBuildDepartment;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerBuildDepartment -= HandleOnPlayerBuildDepartment;
        }

        private void HandleOnPlayerBuildDepartment() => _buttonBuildButton.gameObject.SetActive(true);
    }
}