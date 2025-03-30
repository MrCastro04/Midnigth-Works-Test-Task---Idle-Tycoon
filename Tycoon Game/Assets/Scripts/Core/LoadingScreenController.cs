using System.Collections;
using TMPro;
using UI.Canvas;
using UnityEngine;
using UnityEngine.UI;

namespace Core
{
    public class LoadingScreenController : MonoBehaviour
    {
        [SerializeField] private LoadingCanvas _loadingCanvas;
        [SerializeField] private Slider _progressBar;
        [SerializeField] private TextMeshProUGUI _loadingText;

        private void Start()
        {
            _loadingCanvas.SetActive(true);
            _loadingText.text = "Loading...";
            StartCoroutine(LoadSceneAsync());
        }

        private IEnumerator LoadSceneAsync()
        {
            while (_progressBar.value < _progressBar.maxValue)
            {
                _progressBar.value += (_progressBar.maxValue * 0.01f) / 5f;

                yield return null;
            }

            SceneTransition.Initiate(1);
        }
    }
}