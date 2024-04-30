using System;
using UnityEngine;

namespace HW1.Task1
{
    public class InputSystem : MonoBehaviour
    {
        public event Action ShootEvent;
        public event Action ChangeEvent;
       
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                ShootEvent?.Invoke();
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                ChangeEvent?.Invoke();
            }
        }
    }
}