using Core;
using Department;
using TMPro;
using UnityEngine;

namespace UI.CanvasComponents
{
    public class BreadDepartmentCostView : MonoBehaviour
    {
        [SerializeField] private BreadDepartment _breadDepartment;

        private TextMeshProUGUI _costText;

        private void Awake()
        {
            _costText = GetComponentInChildren<TextMeshProUGUI>();
        }

        private void OnEnable()
        {
            EventManager.OnPlayerUpgradeBreadDepartment += HandleUpdated;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerUpgradeBreadDepartment -= HandleUpdated;
        }

        private void HandleUpdated(BreadDepartment updated)
        {
            if (updated != _breadDepartment) return;

            _costText.text = _breadDepartment.CurrentUpgradeCost.ToString();
        }
    }
}