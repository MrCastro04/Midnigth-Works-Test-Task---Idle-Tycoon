using Core;
using UnityEngine;

namespace Building
{
    [RequireComponent(typeof(BoxCollider))]
    public class BuildSpot : MonoBehaviour
    {
        [SerializeField] private GameObject _colorBuildZone;

        private Department _builtDepartment;
        private BoxCollider _boxCollider;

        public bool IsEmpty => _builtDepartment == null;

        private void Awake()
        {
            _boxCollider = GetComponent<BoxCollider>();
        }

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