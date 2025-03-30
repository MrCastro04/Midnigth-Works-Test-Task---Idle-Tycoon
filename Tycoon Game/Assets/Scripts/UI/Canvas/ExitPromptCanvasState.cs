using Core;

namespace UI.Canvas
{
    public class ExitPromptCanvasState : BaseCanvasState
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