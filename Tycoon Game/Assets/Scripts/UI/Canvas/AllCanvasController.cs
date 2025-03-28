using System;
using Core;
using Scriptable_Objects;
using UnityEngine;

namespace UI.Canvas
{
    public class AllCanvasController : MonoBehaviour
    {
        private UpgradeBreadDepCanvasController _upgradeBreadDepCanvas;

        private void Awake()
        {
            _upgradeBreadDepCanvas = GetComponentInChildren<UpgradeBreadDepCanvasController>();
        }

        private void OnEnable()
       {
           EventManager.OnPlayerClickOnDepartment += HandlePlayerClickOnDepartment;
       }

       private void OnDisable()
       {
           EventManager.OnPlayerClickOnDepartment -= HandlePlayerClickOnDepartment;
       }

       private void HandlePlayerClickOnDepartment(DepartmentData departmentData)
       {
           switch (departmentData.DepartmentName)
           {
                 case "Bread Department":

                     _upgradeBreadDepCanvas.SetActiveCanvasTrue();

                     EventManager.RaiseOnCanvasActive();
                     break;

                 // додати Cashier Department
           }
       }
    }
}