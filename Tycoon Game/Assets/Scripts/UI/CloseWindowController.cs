using Core;
using UnityEngine;

namespace UI
{
    public class CloseWindowController : MonoBehaviour
    {
       [SerializeField] private CloseWindowButton _button;

       private void OnEnable()
       {
           EventManager.OnPlayerClickBuildButton += HandlePlayerClickBuildButton;
           EventManager.OnPlayerBuildDepartment += HandlePlayerBuildDepartment;
           EventManager.OnPlayerClickCloseWindowButton += HandlePlayerClickCloseWindowButton;
           EventManager.OnCanvasActive += HandleCanvasActive;
       }

       private void OnDisable()
       {
           EventManager.OnPlayerClickBuildButton -= HandlePlayerClickBuildButton;
           EventManager.OnPlayerBuildDepartment -= HandlePlayerBuildDepartment;
             EventManager.OnPlayerClickCloseWindowButton -= HandlePlayerClickCloseWindowButton;
             EventManager.OnCanvasActive -= HandleCanvasActive;
       }

       private void HandlePlayerClickBuildButton() => SetButtonActiveTrue();
       private void HandleCanvasActive() => SetButtonActiveTrue();
       private void HandlePlayerClickCloseWindowButton() => SetButtonActiveFalse();
       private void HandlePlayerBuildDepartment() => SetButtonActiveFalse();

       private void SetButtonActiveFalse() => _button.gameObject.SetActive(false);
       private void SetButtonActiveTrue() => _button.gameObject.SetActive(true);
    }
}
