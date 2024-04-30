using UnityEngine;

namespace HW1.Task1
{
    public class Weapon1: Weapon
    {
        [SerializeField] private int _countBullets;

        public override void Shoot()
        {
            base.Shoot();
            _countBullets --;
        }

        public override bool IsCanShoot()
        {
            return _countBullets != 0;
        }
    }
}