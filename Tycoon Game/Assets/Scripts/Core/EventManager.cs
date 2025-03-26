using System;

namespace Core
{
    public static class EventManager
    {
        public static event Action OnPlayerClickBuildButton;

        public static void RaisePlayerClickBuildButton() => OnPlayerClickBuildButton?.Invoke();
    }
}