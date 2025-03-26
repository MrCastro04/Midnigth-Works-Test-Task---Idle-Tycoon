using Core;
using UnityEngine;

namespace UI
{
    public class BuildingsCanvas : MonoBehaviour
    {
        [SerializeField] private BuildingsViwer _buildingsViwer;

        private void OnEnable()
        {
            EventManager.OnPlayerClickBuildButton += HandlePlayerClickBuildButton;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerClickBuildButton -= HandlePlayerClickBuildButton;
        }

        private void HandlePlayerClickBuildButton()
        {
            _buildingsViwer.gameObject.SetActive(true);
        }
    }
}