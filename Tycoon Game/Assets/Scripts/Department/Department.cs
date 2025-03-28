using Core;
using Interfaces;
using Scriptable_Objects;
using UnityEngine;

namespace Department
{
    public class Department : MonoBehaviour , IClickablePrefab
    {
        private DepartmentData _data;

        public void Init(DepartmentData data)
        {
            _data = data;
        }

        public void OnMouseDown()
        {
          EventManager.RaiseOnPlayerClickOnDepartment(this._data);
        }
    }
}