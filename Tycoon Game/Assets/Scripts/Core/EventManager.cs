using System;
using Scriptable_Objects;

namespace Core
{
    public static class EventManager
    {
        public static event Action OnPlayerClickBuildButton;
        public static event Action OnPlayerClickBuildingImageButton;
        public static event Action OnPlayerBuildDepartment;
        public static event Action OnPlayerClickCloseWindowButton;
        public static event Action OnPlayerClickSelectLevelButton;
        public static event Action OnCanvasActive;
        public static event Action<DepartmentData> OnPlayerClickOnDepartment;

        // MAIN MENU
        public static void RaiseOnPlayerClickSelectLevelButton() => OnPlayerClickSelectLevelButton?.Invoke();



        // GAMEPLAY
        public static void RaisePlayerClickBuildButton() => OnPlayerClickBuildButton?.Invoke();
        public static void RaiseOnPlayerClickBuildingImageButton() => OnPlayerClickBuildingImageButton?.Invoke();
        public static void RaiseOnPlayerBuildDepartment() => OnPlayerBuildDepartment?.Invoke();
        public static void RaiseOnPlayerClickCloseWindowButton() => OnPlayerClickCloseWindowButton?.Invoke();
        public static void RaiseOnCanvasActive() => OnCanvasActive?.Invoke();

        public static void RaiseOnPlayerClickOnDepartment (DepartmentData departmentData) =>
            OnPlayerClickOnDepartment?.Invoke(departmentData);
    }
}