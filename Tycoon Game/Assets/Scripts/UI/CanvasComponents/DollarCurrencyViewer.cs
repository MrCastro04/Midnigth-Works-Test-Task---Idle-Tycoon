using Core;
using TMPro;
using UnityEngine;

namespace UI.CanvasComponents
{
    public class DollarCurrencyViewer : MonoBehaviour
    {
        private TextMeshProUGUI _dollarTextAmount;

        private void Awake()
        {
            _dollarTextAmount = GetComponentInChildren<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            EventManager.OnPlayerGetDollars += HandlePlayerGetDollars;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerGetDollars += HandlePlayerGetDollars;
        }

        private void HandlePlayerGetDollars(int dollarAmount)
        {
            _dollarTextAmount.text = dollarAmount.ToString();
        }
    }
}