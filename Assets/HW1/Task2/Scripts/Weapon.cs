using UnityEngine;

namespace HW1.Task1
{
    public abstract class Weapon : MonoBehaviour
    {
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private Transform _placeForBullet;

        protected Transform PlaceForBullet => _placeForBullet;

        public virtual void Shoot()
        {
            CreateBullet(_placeForBullet.position);
        }
       
        protected void CreateBullet(Vector3 position)
        {
            var newButton = Instantiate(
                _bulletPrefab,
                position,
                Quaternion.identity);

            newButton.Init(transform.forward);
        }

        public abstract bool IsCanShoot();
    }
}