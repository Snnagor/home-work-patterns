using UnityEngine;

namespace HW3.Task2
{
    public abstract class Enemy: MonoBehaviour
    {
        private float _lifeTime;
        
        public void Init(float lifeTime)
        {
            _lifeTime = lifeTime;
            Attack();
            Remove();
        }
        
        protected abstract void Attack();
        
        public void MoveTo(Vector3 position) => transform.position = position;

        private void Remove()
        {
            Destroy(gameObject, _lifeTime);
        }
    }
}