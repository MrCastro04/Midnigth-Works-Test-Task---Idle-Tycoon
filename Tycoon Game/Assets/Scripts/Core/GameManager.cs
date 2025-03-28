using UnityEngine;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        private void OnEnable()
        {
            EventManager.OnCanvasActive += HandleCanvasActive;
            EventManager.OnPlayerClickCloseWindowButton += HandlePlayerClickCloseWindowButton;
        }

        private void OnDisable()
        {
            EventManager.OnCanvasActive -= HandleCanvasActive;
            EventManager.OnPlayerClickCloseWindowButton -= HandlePlayerClickCloseWindowButton;
        }

        private void HandleCanvasActive()
        {
            Time.timeScale = 0f;
        }

        private void HandlePlayerClickCloseWindowButton()
        {
            Time.timeScale = 1f;
        }
    }
}
