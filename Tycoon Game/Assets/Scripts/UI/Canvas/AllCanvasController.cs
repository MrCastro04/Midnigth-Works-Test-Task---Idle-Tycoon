using Core;
using Scriptable_Objects;
using UnityEngine;

namespace UI.Canvas
{
    public class AllCanvasController : MonoBehaviour
    {
        private UpgradeBreadDepCanvasController _upgradeBreadDepCanvas;
        private UpgradeCashierDepCanvasController _upgradeCashierDepCanvas;

        private void Awake()
        {
            _upgradeBreadDepCanvas = GetComponentInChildren<UpgradeBreadDepCanvasController>();

            _upgradeCashierDepCanvas = GetComponentInChildren<UpgradeCashierDepCanvasController>();
        }

        private void OnEnable()
       {
           EventManager.OnPlayerClickOnDepartment += HandlePlayerClickOnDepartment;
       }

       private void OnDisable()
       {
           EventManager.OnPlayerClickOnDepartment -= HandlePlayerClickOnDepartment;
       }

       private void HandlePlayerClickOnDepartment(DepartmentData departmentData)
       {
           switch (departmentData.DepartmentName)
           {
                 case "Bread Department":

                     _upgradeBreadDepCanvas.SetActiveCanvasTrue();

                     EventManager.RaiseOnCanvasActive();

                     break;

                 case "Cash Department":

                     _upgradeCashierDepCanvas.SetActiveCanvasTrue();

                     EventManager.RaiseOnCanvasActive();

                     break;
           }
       }
    }
}