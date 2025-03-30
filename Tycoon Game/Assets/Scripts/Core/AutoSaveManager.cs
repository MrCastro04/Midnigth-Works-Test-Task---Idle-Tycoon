using UnityEngine;

namespace Core
{
    public class AutoSaveManager : MonoBehaviour
    {
        [SerializeField] private float saveInterval = 15f;

        private float _timer;

        private void Update()
        {
            _timer += Time.deltaTime;

            if (_timer >= saveInterval)
            {
                Save();
                _timer = 0f;
            }
        }

        private void OnApplicationQuit()
        {
            Save();
        }

        private void Save()
        {
            if (GameManager.Instance != null && GameManager.Instance.CurrentSave != null)
            {
                GameManager.Instance.CurrentSave.Dollars = PlayerResources.Instance.Dollars;
                GameManager.Instance.CurrentSave.Gems = PlayerResources.Instance.Gems;

                SaveSystem.Save(GameManager.Instance.CurrentSave);

                Debug.Log("Автосейв виконано!");
            }
            else
            {
                Debug.LogWarning("GameManager або SaveData не ініціалізовано!");
            }
        }
    }
}