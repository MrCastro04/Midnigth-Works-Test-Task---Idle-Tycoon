using Scriptable_Objects;
using UnityEngine;

namespace Building
{
    public class Department : MonoBehaviour
    {
        private DepartmentData _data;

        public DepartmentData GetData() => _data;

        public void Init(DepartmentData data)
        {
            _data = data;
        }
    }
}