using UnityEngine;

namespace HW1.Task1
{
    public class Shooter: MonoBehaviour
    {
        private InputSystem _inputSystem;
        private Weapon _currentWeapon;

        private void Awake()
        {
            _inputSystem = GetComponent<InputSystem>();
        }

        private void OnEnable()
        {
            _inputSystem.ShootEvent += Shoot;
        }

        private void OnDisable()
        {
            _inputSystem.ShootEvent -= Shoot;
        }

        public void SetWeapon(Weapon currentWeapon)
        {
            _currentWeapon = currentWeapon;
        }
        
        private void Shoot()
        {
            if (_currentWeapon.IsCanShoot() == false)
                return;
                
            _currentWeapon.Shoot();
        }
    }
}