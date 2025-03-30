using Core;
using Scriptable_Objects;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UI.Canvas
{
    public class AllCanvasController : MonoBehaviour
    {
        private UpgradeBreadDepCanvasController _upgradeBreadDepCanvas;
        private UpgradeCashierDepCanvasController _upgradeCashierDepCanvas;
        private ExitPromtCanvasController _exitPromtCanvas;
        private bool _canExitPromtCanvas = true;

        private void Awake()
        {
            _upgradeBreadDepCanvas = GetComponentInChildren<UpgradeBreadDepCanvasController>();

            _upgradeCashierDepCanvas = GetComponentInChildren<UpgradeCashierDepCanvasController>();

            _exitPromtCanvas = GetComponentInChildren<ExitPromtCanvasController>();
        }

        private void OnEnable()
       {
           EventManager.OnPlayerClickOnDepartment += HandlePlayerClickOnDepartment;
       }

       private void OnDisable()
       {
           EventManager.OnPlayerClickOnDepartment -= HandlePlayerClickOnDepartment;
       }

       public void HandleExitPromt(InputAction.CallbackContext context)
       {
           if(context.performed == false || !_canExitPromtCanvas) return;

           
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