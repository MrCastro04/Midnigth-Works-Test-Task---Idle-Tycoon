using Core;

namespace UI.Canvas
{
    public class UpgradeBreadDepCanvasState : BaseCanvasState
    {
        protected override void SubscribeToEvents()
        {
            EventManager.OnPlayerClickCloseWindowButton += ExitState;
        }

        protected override void UnsubscribeFromEvents()
        {
            EventManager.OnPlayerClickCloseWindowButton -= ExitState;
        }
    }
}