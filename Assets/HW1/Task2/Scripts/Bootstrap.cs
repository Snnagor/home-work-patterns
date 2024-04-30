using UnityEngine;

namespace HW1.Task1
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private WeaponSwitcher _weaponSwitcher;

        private void Start()
        {
            _weaponSwitcher.Init();
        }
    }
}