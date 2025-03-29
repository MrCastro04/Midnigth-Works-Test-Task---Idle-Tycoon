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
        public static event Action OnCanvasActive;
        public static event Action<DepartmentData> OnPlayerClickOnDepartment;
        public static event Action <int> OnPlayerGetDollars;
        public static event Action <int> OnPlayerGetGems;
        public static event Action <int> OnPlayerSpendDollars;
        public static event Action <int> OnPlayerSpendGems;

        public static void RaisePlayerClickBuildButton() => OnPlayerClickBuildButton?.Invoke();
        public static void RaiseOnPlayerClickBuildingImageButton() => OnPlayerClickBuildingImageButton?.Invoke();
        public static void RaiseOnPlayerBuildDepartment() => OnPlayerBuildDepartment?.Invoke();
        public static void RaiseOnPlayerClickCloseWindowButton() => OnPlayerClickCloseWindowButton?.Invoke();
        public static void RaiseOnCanvasActive() => OnCanvasActive?.Invoke();

        public static void RaiseOnPlayerClickOnDepartment (DepartmentData departmentData) =>
            OnPlayerClickOnDepartment?.Invoke(departmentData);

        public static void RaiseOnPlayerGetDollars(int newAmount) => OnPlayerGetDollars?.Invoke(newAmount);
        public static void RaiseOnPlayerGetGems(int newAmount) => OnPlayerGetGems?.Invoke(newAmount);
        public static void RaiseOnPlayerSpendDollars(int newAmount) => OnPlayerSpendDollars?.Invoke(newAmount);
        public static void RaiseOnPlayerSpendGems(int newAmount) => OnPlayerSpendGems?.Invoke(newAmount);
    }
}