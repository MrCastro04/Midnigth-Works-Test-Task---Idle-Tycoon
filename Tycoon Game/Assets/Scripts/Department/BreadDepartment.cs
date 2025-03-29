using UnityEngine;

namespace Department
{
    public class BreadDepartment : MonoBehaviour
    {
        private int _currentLevel;
        private int _lastLevel;
        private int _priceValue;
        private int _processingValue;
        private int _currentUpgradeCost;
        private Department _department;

        private void Awake()
        {
            _department = GetComponent<Department>();
        }
    }
}