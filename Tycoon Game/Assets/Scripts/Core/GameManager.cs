using UnityEngine;

namespace Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        public SaveData CurrentSave { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;

            DontDestroyOnLoad(gameObject);
        }

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

        public void InitializeWithSave(SaveData data)
        {
            CurrentSave = data;
            Debug.Log($"Прогрес завантажено: гроші: {data.Dollars}");
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
