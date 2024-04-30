using UnityEngine;

namespace HW1.Task4
{
    public class ClickControl
    {
        private Camera _camera = Camera.main;
        private Ray _ray;

        public Ball CreateClick()
        {
            _ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(_ray, out RaycastHit hit, 100f))
            {
                if (hit.collider.TryGetComponent(out Ball ball))
                {
                    return ball;
                }
            }

            return null;
        }
    }
}