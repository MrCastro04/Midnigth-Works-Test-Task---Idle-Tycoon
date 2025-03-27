using Buttons;
using Core;
using UnityEngine;

namespace UI
{
    public class BuildButtonController : MonoBehaviour
    {
       [SerializeField] private BuildButton _button;

       private void OnEnable()
       {
           EventManager.OnPlayerClickBuildButton += HandlePlayerClickBuildButton;
           EventManager.OnPlayerBuildDepartment += HandlePlayerBuildDepartment;
       }

       private void OnDisable()
       {
           EventManager.OnPlayerClickBuildButton -= HandlePlayerClickBuildButton;
           EventManager.OnPlayerBuildDepartment -= HandlePlayerBuildDepartment;
       }

       private void HandlePlayerClickBuildButton()
       {
           _button.gameObject.SetActive(false);
       }

       private void HandlePlayerBuildDepartment()
       {
           _button.gameObject.SetActive(true);
       }
    }
}
