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
       }

       private void OnDisable()
       {
           EventManager.OnPlayerClickBuildButton -= HandlePlayerClickBuildButton;
           EventManager.OnPlayerBuildDepartment -= HandlePlayerBuildDepartment;
             EventManager.OnPlayerClickCloseWindowButton -= HandlePlayerClickCloseWindowButton;
       }

       private void HandlePlayerClickBuildButton()
       {
           _button.gameObject.SetActive(true);
       }

       private void HandlePlayerBuildDepartment()
       {
           _button.gameObject.SetActive(false);
       }

       private void HandlePlayerClickCloseWindowButton()
       {
           _button.gameObject.SetActive(false);
       }
    }
}
