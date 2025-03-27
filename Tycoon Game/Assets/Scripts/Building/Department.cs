using Interfaces;
using Scriptable_Objects;
using UnityEngine;

namespace Building
{
    public class Department : MonoBehaviour , IClickablePrefab
    {
        private DepartmentData _data;

        public DepartmentData GetData() => _data;

        public void Init(DepartmentData data)
        {
            _data = data;
        }

        public void OnMouseDown()
        {
            Debug.Log("123");
        }
    }
}