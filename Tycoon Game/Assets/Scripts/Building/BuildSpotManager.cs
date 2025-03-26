using Core;
using UnityEngine;

namespace Building
{
    public class BuildSpotManager : MonoBehaviour
    {
        private BuildSpot[] _buildSpots;

        private void Awake()
        {
            _buildSpots = GetComponentsInChildren<BuildSpot>();

            Debug.Log($"Знайдено точок для будівництва: {_buildSpots.Length}");
        }

        private void OnEnable()
        {
            EventManager.OnPlayerClickBuildButton += HandlePlayerClickBuildButton;
        }

        private void OnDisable()
        {
            EventManager.OnPlayerClickBuildButton += HandlePlayerClickBuildButton;
        }

        private void HandlePlayerClickBuildButton()
        {
            foreach (var buildSpot in _buildSpots)
            {
                buildSpot.ShowBuildZone();
            }
        }
    }
}
