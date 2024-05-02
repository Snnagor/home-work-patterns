using UnityEngine;

namespace HW3.Task2
{
    public abstract class EnemyFactory
    {
        public EnemyFactory(EnemyConfig config)
        {
        }

        public abstract Enemy Get(EnemyTypes type);

        protected Enemy CreateInstance(Enemy prefab)
        {
            return Object.Instantiate(prefab);
        }
    }
}