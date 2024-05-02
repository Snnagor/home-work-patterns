using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace HW3.Task2
{
    public class EnemySpawner: MonoBehaviour
    {
        [SerializeField] private Transform[] _spawnPoints;
        [SerializeField] private float _spawnCooldown;
        
        private EnemyFactory _enemyFactory;
        private Coroutine _spawn;
        
        public void StartWork(EnemyFactory enemyFactory)
        {
            _enemyFactory = enemyFactory;
            
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        public void StopWork()
        {
            if(_spawn != null)
                StopCoroutine(_spawn);
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                EnemyTypes enemyType = (EnemyTypes) Random.Range(0, Enum.GetValues(typeof(EnemyTypes)).Length);
                Enemy enemy = _enemyFactory.Get(enemyType);
                Vector3 randomPosition = _spawnPoints[Random.Range(0, _spawnPoints.Length)].position; 
                enemy.MoveTo(randomPosition);
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }
    }
}