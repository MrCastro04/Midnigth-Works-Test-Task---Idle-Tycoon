using Core;
using Interfaces;
using Scriptable_Objects;
using UnityEngine;

namespace Department
{
    public class Department : MonoBehaviour , IClickablePrefab
    {
        [SerializeField] private DepartmentData _data;

        public DepartmentData Data => _data;

        public void OnMouseDown()
        {
            if (_data == null)
            {
                Debug.LogError($"_data не задано в Department на {gameObject.name}");
                return;
            }

            EventManager.RaiseOnPlayerClickOnDepartment(_data);
        }
    }
}