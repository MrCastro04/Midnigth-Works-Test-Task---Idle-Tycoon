using UnityEngine;
using UnityEngine.UI;

namespace UI.CanvasComponents
{
    public class ProgressbarController : MonoBehaviour
    {
        private Slider _slider;

        private void Awake()
        {
            _slider = GetComponent<Slider>();
        }

        public void RegisterValues(float minValue, float maxValue, float currentValue)
        {
            _slider.minValue = minValue;

            _slider.maxValue = maxValue;

            _slider.value = currentValue;
        }

        public void UpdateProgress(float progressValue)
        {
            _slider.value += progressValue;
        }
    }
}