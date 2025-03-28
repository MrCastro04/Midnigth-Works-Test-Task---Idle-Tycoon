using System;
using Core;
using Scriptable_Objects;
using UnityEngine;

namespace UI.Canvas
{
    public class AllCanvasController : MonoBehaviour
    {
       [SerializeField] private UpgradeBreadDepCanvasController _upgradeBreadDepCanvas;

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
        
       }
    }
}