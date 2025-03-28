
using System;
using Core;
using UnityEngine;

namespace UI.Canvas
{
    public class UpgradeBreadDepCanvasController : MonoBehaviour
    {
        private UnityEngine.Canvas _canvas;

        private void Awake()
        {
            _canvas = GetComponent<UnityEngine.Canvas>();
        }

        private void OnEnable()
        {
            EventManager.OnPlayerClickCloseWindowButton += HandlePlayerClickCloseWindowButton;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerClickCloseWindowButton -= HandlePlayerClickCloseWindowButton;
        }

        public void SetActiveCanvasTrue()
        {
            if (_canvas.enabled == false)
            {
                _canvas.enabled = true;
            }
        }

        private void SetActiveCanvasFalse()
        {
            if (_canvas.enabled )
            {
                _canvas.enabled = false;
            }
        }

        private void HandlePlayerClickCloseWindowButton() => SetActiveCanvasFalse();
    }
}