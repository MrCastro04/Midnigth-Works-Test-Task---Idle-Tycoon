using Core;
using UnityEngine;

namespace Building
{
    public class BuildSpot : MonoBehaviour
    {
        [SerializeField] private GameObject _colorBuildZone;

        private Department _builtDepartment;

        public bool IsEmpty => _builtDepartment == null;

        public void Build(DepartmentData data)
        {
            if (IsEmpty == false)
            {
                Debug.LogWarning("Already built here!");

                return;
            }

            GameObject departmentGO = Instantiate(data.Prefab, transform.position, Quaternion.identity);

            _builtDepartment = departmentGO.GetComponent<Department>();

            _builtDepartment.Init(data);

            EventManager.RaiseOnPlayerBuildDepartment();
        }

        public void ShowBuildZone()
        {
            _colorBuildZone.gameObject.SetActive(true);
        }
    }
}