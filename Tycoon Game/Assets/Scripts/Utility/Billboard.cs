using UnityEngine;

namespace Utility
{
    public class Billboard : MonoBehaviour
    {
        private Camera _camera;

        private void Awake()
        {
            _camera = Camera.main;
        }

        private void LateUpdate()
        {
            Vector3 cameraDirection = transform.position + _camera.transform.forward;

            transform.LookAt(cameraDirection);
        }
    }
}
