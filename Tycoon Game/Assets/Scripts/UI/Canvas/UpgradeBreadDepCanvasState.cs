using Core;
using Department;
using TMPro;
using UnityEngine;

namespace UI.Canvas
{
    public class UpgradeBreadDepCanvasState : BaseCanvasState
    {
        [SerializeField] private TextMeshProUGUI levelText;
        [SerializeField] private TextMeshProUGUI costText;
        [SerializeField] private TextMeshProUGUI priceText;
        [SerializeField] private TextMeshProUGUI profitText;
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

            levelText.text = save.BreadDepartment_CurentLevel.ToString();
            costText.text = save.BreadDepartment_UpgradeCost.ToString();
            priceText.text = save.BreadDepartment_UnitPrice.ToString();
            profitText.text =$"{_breadDepartment.GetProcessingValue().ToString("F1")} per minute" ;
        }
    }
}