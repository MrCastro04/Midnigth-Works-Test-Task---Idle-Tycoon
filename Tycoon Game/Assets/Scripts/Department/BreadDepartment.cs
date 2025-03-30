using Core;
using UnityEngine;

namespace Department
{
      public class BreadDepartment : MonoBehaviour
    {
        private int _currentLevel;
        private int _lastLevel = 100;
        private int _priceValue;
        private int _currentUpgradeCost;
        private float _processingCooldown = 3f;
        private Department _department;


        private void Awake()
        {
            _department = GetComponent<Department>();
        }

        private void Start()
        {
            var save = GameManager.Instance.CurrentSave;

            _currentLevel = save.BreadDepartment_CurentLevel;
            _currentUpgradeCost = save.BreadDepartment_UpgradeCost;
            _priceValue = save.BreadDepartment_UnitPrice;
        }

        private void OnEnable()
        {
            EventManager.OnPlayerClickOnBreadDepartmentUpgradeButton += HandlePlayerClickOnBreadDepartmentUpgradeButton;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerClickOnBreadDepartmentUpgradeButton -= HandlePlayerClickOnBreadDepartmentUpgradeButton;
        }

        private void HandlePlayerClickOnBreadDepartmentUpgradeButton()
        {
            TryUpgradeBreadDepartment();
        }

        private void TryUpgradeBreadDepartment()
        {
            if (PlayerResources.Instance.Dollars < _currentUpgradeCost) return;

            PlayerResources.Instance.SpendDollars(_currentUpgradeCost);

            UpgradeDepartment();
        }

        private void UpgradeDepartment()
        {
            if(_currentLevel >= _lastLevel) return;

            _currentLevel++;
            _currentUpgradeCost *= 2;
            _priceValue += (_currentUpgradeCost / 10);


            var save = GameManager.Instance.CurrentSave;
            save.BreadDepartment_CurentLevel = _currentLevel;
            save.BreadDepartment_UpgradeCost = _currentUpgradeCost;
            save.BreadDepartment_UnitPrice = _priceValue;

            SaveSystem.Save(save);
            EventManager.RaiseOnPlayerUpgradeBreadDepartment();
        }

        public float GetProcessingValue()
        {
            float unitsPerMinute = 60f / _processingCooldown;
            return unitsPerMinute * _priceValue;
        }
    }
}
