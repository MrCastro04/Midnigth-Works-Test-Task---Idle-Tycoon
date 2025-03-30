using UnityEngine;

namespace UI.Canvas
{
    public abstract class BaseCanvasState : MonoBehaviour
    {
        protected UnityEngine.Canvas Canvas;
        protected AllCanvasController AllCanvasController;

        protected virtual void Awake()
        {
            Canvas = GetComponent<UnityEngine.Canvas>();

            AllCanvasController = GetComponentInParent<AllCanvasController>();
        }

        public virtual void EnterState()
        {
            Canvas.enabled = true;

            SubscribeToEvents();
        }

        public virtual void ExitState()
        {
            Canvas.enabled = false;

            UnsubscribeFromEvents();
        }

        protected abstract void SubscribeToEvents();
        protected abstract void UnsubscribeFromEvents();
    }
}