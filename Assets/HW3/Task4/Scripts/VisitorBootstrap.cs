using UnityEngine;

namespace HW3.Task4
{
    public class VisitorBootstrap : MonoBehaviour
    {
        [SerializeField] private Spawner _spawner;

        private Score _score;
        private EnemyWeight _enemyWeight;

        private void Awake()
        {
            _score = new Score(_spawner);
            _enemyWeight = new EnemyWeight(_spawner);
            _spawner.StartWork(_enemyWeight);
        }

        private void Update()
        {
            if(Input.GetKeyUp(KeyCode.Space))
                _spawner.KillRandomEnemy();
        }
    }
}