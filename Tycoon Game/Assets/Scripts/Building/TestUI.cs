namespace Building
{
    using UnityEngine;

    public class TestUI : MonoBehaviour
    {
        [SerializeField] private DepartmentData _selectedDepartment;

        public void SelectThisDepartment()
        {
            BuildManager.Instance.SelectDepartmentToBuild(_selectedDepartment);
        }
    }
}