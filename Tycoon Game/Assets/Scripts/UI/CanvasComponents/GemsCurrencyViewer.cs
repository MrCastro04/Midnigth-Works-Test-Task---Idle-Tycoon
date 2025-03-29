using Core;
using TMPro;
using UnityEngine;

namespace UI.CanvasComponents
{
    public class GemsCurrencyViewer : MonoBehaviour
    {
        private TextMeshProUGUI _dollarTextAmount;

        private void Awake()
        {
            _dollarTextAmount = GetComponentInChildren<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            EventManager.OnPlayerGetGems += HandlePlayerGetGems;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerGetGems += HandlePlayerGetGems;
        }

        private void HandlePlayerGetGems(int gemsAmount)
        {
            _dollarTextAmount.text = gemsAmount.ToString();
        }
    }
}