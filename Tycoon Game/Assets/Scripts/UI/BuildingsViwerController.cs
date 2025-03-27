using Buttons;
using Core;
using UnityEngine;

namespace UI
{
    public class BuildingsViwerController : MonoBehaviour
    {
       [SerializeField] private BuildingImageButton[] _buttons;

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
            foreach (var button in _buttons)
            {
                button.gameObject.SetActive(true);
            }
        }

        private void HandleOnPlayerClickBuildingImageButton()
        {
            foreach (var button in _buttons)
            {
                button.gameObject.SetActive(false);
            }
        }
    }
}