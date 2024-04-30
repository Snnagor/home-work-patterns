using DG.Tweening;
using UnityEngine;

namespace HW1.Task1
{
    public class Bullet : MonoBehaviour
    {
        private const float FiringRange = 50;
        private const float Speed = 30;
        
        public void Init(Vector3 direction)
        {
            var duration = FiringRange / Speed;
            transform.DOMove(direction * FiringRange, duration)
                .SetEase(Ease.Linear)
                .OnComplete(DestroyBullet);
        }

        private void DestroyBullet()
        {
            Destroy(gameObject);
        }
    }
}