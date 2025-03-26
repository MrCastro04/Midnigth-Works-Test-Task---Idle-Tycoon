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
            EventManager.OnPlayerClickBuildingImageButton += HandleOnPlayerClickBuildingImageButton;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerClickBuildButton -= HandlePlayerClickBuildButton;
            EventManager.OnPlayerClickBuildingImageButton -= HandleOnPlayerClickBuildingImageButton;
        }

        private void HandlePlayerClickBuildButton()
        {
            _buildingsViwer.gameObject.SetActive(true);
        }

        private void HandleOnPlayerClickBuildingImageButton()
        {
            _buildingsViwer.gameObject.SetActive(false);
        }
    }
}