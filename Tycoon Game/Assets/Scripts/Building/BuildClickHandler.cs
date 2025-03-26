using UnityEngine;

namespace Building
{
    public class BuildClickHandler : MonoBehaviour
    {
        [SerializeField] private LayerMask _buildSpotMask;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out RaycastHit hit, 100f, _buildSpotMask))
                {
                    BuildSpot spot = hit.collider.GetComponent<BuildSpot>();

                    if (spot != null)
                    {
                        BuildManager.Instance.TryBuildAtSpot(spot);
                    }
                }
            }
        }
    }
}