using UnityEngine;

namespace UI.Canvas
{
    public class LoadingCanvas : MonoBehaviour
    {
        private UnityEngine.Canvas _canvas;

        private void Awake()
        {
            _canvas = GetComponent<UnityEngine.Canvas>();
        }

        public void SetActive(bool value)
        {
            _canvas.enabled = value;
        }
    }
}