using UnityEngine;

namespace HW1.Task1
{
    public class WeaponSwitcher : MonoBehaviour
    {
        [SerializeField] private Weapon[] _weapons;
        
        private InputSystem _inputSystem;
        private Shooter _shooter;
        private Weapon _currentWeapon;
        
        private int _currentWeaponId;

        private void Awake()
        {
            _inputSystem = GetComponent<InputSystem>();
            _shooter = GetComponent<Shooter>();
        }
        
        private void OnEnable()
        {
            _inputSystem.ChangeEvent += ChangeWeapon;
        }

        private void OnDisable()
        {
            _inputSystem.ChangeEvent -= ChangeWeapon;
        }

        public void Init()
        {
            DeactivateAllWeapon();
            SetWeapon(_currentWeaponId);
        }
        
        private void DeactivateAllWeapon()
        {
            foreach (var item in _weapons)
            {
                item.gameObject.SetActive(false);
            }
        }
        
        private void ChangeWeapon()
        {
            SetNextWeaponId();
            SetWeapon(_currentWeaponId);
        }

        private void SetNextWeaponId()
        {
            if (_currentWeaponId == _weapons.Length - 1)
            {
                _currentWeaponId = 0;
            }
            else
            {
                _currentWeaponId++;
            }
        }

        private void SetWeapon(int idNewWeapon)
        {
            if (_currentWeapon != null)
            {
                _currentWeapon.gameObject.SetActive(false);
            }

            _currentWeapon = _weapons[idNewWeapon];
            _shooter.SetWeapon(_currentWeapon);

            _currentWeapon.gameObject.SetActive(true);
        }
    }
}