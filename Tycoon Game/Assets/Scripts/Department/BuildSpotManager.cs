using Core;
using UnityEngine;

namespace Department
{
    public class BuildSpotManager : MonoBehaviour
    {
        private BuildSpot[] _buildSpots;

        private void Awake()
        {
            _buildSpots = GetComponentsInChildren<BuildSpot>();
        }

        private void OnEnable()
        {
            EventManager.OnPlayerClickBuildingImageButton += HandlePlayerClickBuildButton;
            EventManager.OnPlayerBuildDepartment += HandlePlayerBuildDepartment;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerClickBuildingImageButton += HandlePlayerClickBuildButton;
            EventManager.OnPlayerBuildDepartment -= HandlePlayerBuildDepartment;
        }

        private void HandlePlayerClickBuildButton()
        {
            foreach (var buildSpot in _buildSpots)
            {
                buildSpot.ShowBuildZone();
            }
        }

        private void HandlePlayerBuildDepartment()
        {
            foreach (var buildSpot in _buildSpots)
            {
                buildSpot.HideBuildZone();
            }
        }
    }
}
