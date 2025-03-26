using System;

namespace Core
{
    public static class EventManager
    {
        public static event Action OnPlayerClickBuildButton;
        public static event Action OnPlayerClickBuildingImageButton;
        public static event Action OnPlayerBuildDepartment;

        public static void RaisePlayerClickBuildButton() => OnPlayerClickBuildButton?.Invoke();
        public static void RaiseOnPlayerClickBuildingImageButton() => OnPlayerClickBuildingImageButton?.Invoke();
        public static void RaiseOnPlayerBuildDepartment() => OnPlayerBuildDepartment?.Invoke();
    }
}