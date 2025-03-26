using UnityEngine;

namespace Building
{
    public class BuildManager : MonoBehaviour
    {
        [SerializeField] private DepartmentData[] _availableDepartments;

        public static BuildManager Instance { get; private set; }

        private DepartmentData _currentSelectedDepartment;

        private void Awake()
        {
            if (Instance != null)
            {
                Destroy(gameObject);
            }

            Instance = this;
        }

        public void SelectDepartmentToBuild(DepartmentData department)
        {
            _currentSelectedDepartment = department;
        }

        public void TryBuildAtSpot(BuildSpot spot)
        {
            if (_currentSelectedDepartment == null || !spot.IsEmpty)
                return;

            spot.Build(_currentSelectedDepartment);
        }
    }
}