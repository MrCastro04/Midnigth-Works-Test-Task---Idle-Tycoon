using Core;
using Scriptable_Objects;
using UnityEngine;
using UnityEngine.InputSystem;

namespace UI.Canvas
{
    public class AllCanvasController : MonoBehaviour
    {
        public UpgradeBreadDepCanvasState BreadState;
        public UpgradeCashierDepCanvasState CashierState;
        public ExitPromptCanvasState ExitPromptState;

        private BaseCanvasState _currentState;

        private void Awake()
        {
            BreadState = GetComponentInChildren<UpgradeBreadDepCanvasState>(true);
            CashierState = GetComponentInChildren<UpgradeCashierDepCanvasState>(true);
            ExitPromptState = GetComponentInChildren<ExitPromptCanvasState>(true);
        }

        private void OnEnable()
        {
            EventManager.OnPlayerClickOnDepartment += HandleDepartmentClick;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerClickOnDepartment -= HandleDepartmentClick;
        }

        public void HandleExitPrompt(InputAction.CallbackContext context)
        {
            if (!context.performed) return;

            SwitchState(ExitPromptState);
        }

        private void HandleDepartmentClick(DepartmentData data)
        {
            switch (data.DepartmentName)
            {
                case "Bread Department":
                    SwitchState(BreadState);
                    break;

                case "Cash Department":
                    SwitchState(CashierState);
                    break;
            }

            EventManager.RaiseOnCanvasActive();
        }

        public void SwitchState(BaseCanvasState newState)
        {
            _currentState?.ExitState();

            _currentState = newState;

            _currentState.EnterState();
        }
    }
}