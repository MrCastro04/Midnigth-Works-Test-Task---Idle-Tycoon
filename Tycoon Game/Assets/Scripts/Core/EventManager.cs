using System;

namespace Core
{
    public static class EventManager
    {
        public static event Action OnPlayerClickBuildButton;
        public static event Action OnPlayerClickBuildingImageButton;
        public static event Action OnPlayerBuildDepartment;
        public static event Action OnPlayerClickCloseWindowButton;
        public static event Action OnPlayerClickSelectLevelButton;

        // MAIN MENU
        public static void RaiseOnPlayerClickSelectLevelButton() => OnPlayerClickSelectLevelButton?.Invoke();



        // GAMEPLAY
        public static void RaisePlayerClickBuildButton() => OnPlayerClickBuildButton?.Invoke();
        public static void RaiseOnPlayerClickBuildingImageButton() => OnPlayerClickBuildingImageButton?.Invoke();
        public static void RaiseOnPlayerBuildDepartment() => OnPlayerBuildDepartment?.Invoke();
        public static void RaiseOnPlayerClickCloseWindowButton() => OnPlayerClickCloseWindowButton?.Invoke();

    }
}