using UnityEngine;

namespace HW3.Task2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private EnemyConfig _enemyConfig;
        [SerializeField] private EnemySpawner _oneSpawner;
        [SerializeField] private EnemySpawner _twoSpawner;
      
        private EnemyFactory[] _factories;
        
        private int _currentIDFactoryForOneSpawn = 0;
        private int _currentIDFactoryForTwoSpawn = 1;

        private void Awake()
        {
            _factories = new EnemyFactory[] { new OrcFactory(_enemyConfig), new ElfFactory(_enemyConfig) };

            InitSpawner();
        }

        private void InitSpawner()
        {
            _oneSpawner.StartWork(_factories[_currentIDFactoryForOneSpawn]);
            _twoSpawner.StartWork(_factories[_currentIDFactoryForTwoSpawn]);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _currentIDFactoryForOneSpawn = GetNextFactoryId(_currentIDFactoryForOneSpawn);
                _currentIDFactoryForTwoSpawn = GetNextFactoryId(_currentIDFactoryForTwoSpawn);

                InitSpawner();
            }
        }

        private int GetNextFactoryId(int currentIdFactory)
        {
            if (currentIdFactory < _factories.Length - 1 && _factories.Length > 1)
            {
                return currentIdFactory + 1;
            }
           
            return 0;
        }
    }
}