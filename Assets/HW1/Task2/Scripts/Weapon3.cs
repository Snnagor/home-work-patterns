using UnityEngine;

namespace HW1.Task1
{
    public class Weapon3: Weapon
    {
        [SerializeField] private int _countBullets;
        
        private const int CountShotBullets = 3;
        private const float DeltaXForPlaceBullet = 0.25f;

        public override bool IsCanShoot()
        {
            return _countBullets >= CountShotBullets;
        }

        public override void Shoot()
        {
            var position = PlaceForBullet.position;
            
            for (int i = 0; i < CountShotBullets; i++)
            {
                var posBullet = new Vector3(position.x + i * DeltaXForPlaceBullet,
                    position.y,
                    position.z);
                
                CreateBullet(posBullet);
                
                _countBullets --;
            }
        }
    }
}