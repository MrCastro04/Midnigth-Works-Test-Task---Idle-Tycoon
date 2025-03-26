using Building;
using Core;
using Scriptable_Objects;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class BuildingImageButton : MonoBehaviour
    {
        [SerializeField] private DepartmentData _departmentData;

        private Image _departmentIcon;

        private void Awake()
        {
            _departmentIcon = GetComponent<Image>();

            _departmentIcon.sprite = _departmentData.Icon;
        }

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(OnClick);
        }

        private void OnClick()
        {
            BuildManager.Instance.SelectDepartmentToBuild(_departmentData);

            EventManager.RaiseOnPlayerClickBuildingImageButton();

            Debug.Log($"Вибрано відділ: {_departmentData.DepartmentName}");
        }
    }
}