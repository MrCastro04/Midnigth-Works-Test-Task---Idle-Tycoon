using Core;
using Scriptable_Objects;
using UnityEngine;

namespace Department
{
    [RequireComponent(typeof(BoxCollider))]
    public class BuildSpot : MonoBehaviour
    {
        [SerializeField] private GameObject _colorBuildZone;

        private global::Department.Department _builtDepartment;
        private BoxCollider _boxCollider;
        private bool _hasDepartment;

        public bool IsEmpty => _builtDepartment == null;

        private void Awake()
        {
            _boxCollider = GetComponent<BoxCollider>();
        }

        public void Build(DepartmentData data)
        {
            if (IsEmpty == false) return;

            GameObject departmentGO = Instantiate(data.Prefab, transform.position, Quaternion.identity);

            _builtDepartment = departmentGO.GetComponent<global::Department.Department>();

            _builtDepartment.Init(data);

            _hasDepartment = true;

            EventManager.RaiseOnPlayerBuildDepartment();
        }

        public void ShowBuildZone()
        {
            if(_hasDepartment) return;

            _boxCollider.enabled = true;

            _colorBuildZone.gameObject.SetActive(true);
        }

        public void HideBuildZone()
        {
            _boxCollider.enabled = false;

            _colorBuildZone.gameObject.SetActive(false);
        }
    }
}