using Core;
using Department;
using TMPro;
using UnityEngine;

namespace UI.Canvas
{
    public class UpgradeBreadDepCanvasState : BaseCanvasState
    {
        [SerializeField] private TextMeshProUGUI _levelText;
        [SerializeField] private TextMeshProUGUI _costText;
        [SerializeField] private TextMeshProUGUI _priceText;
        [SerializeField] private TextMeshProUGUI _profitText;
        [SerializeField] private TextMeshProUGUI _lastLevel;
        [SerializeField] private BreadDepartment _breadDepartment;

        protected override void SubscribeToEvents()
        {
            EventManager.OnPlayerClickCloseWindowButton += ExitState;
            EventManager.OnPlayerUpgradeBreadDepartment += UpdateUI;
        }

        protected override void UnsubscribeFromEvents()
        {
            EventManager.OnPlayerClickCloseWindowButton -= ExitState;
            EventManager.OnPlayerUpgradeBreadDepartment -= UpdateUI;
        }

        public override void EnterState()
        {
            base.EnterState();

            UpdateUI();
        }

        private void UpdateUI()
        {
            var save = GameManager.Instance.CurrentSave;

            _levelText.text = save.BreadDepartment_CurentLevel.ToString();
            _costText.text = save.BreadDepartment_UpgradeCost.ToString();
            _priceText.text = save.BreadDepartment_UnitPrice.ToString();
            _lastLevel.text = save.BreadDepartment_LastLevel.ToString();
            _profitText.text =$"{_breadDepartment.GetProcessingValue().ToString("F1")} per minute" ;
        }
    }
}