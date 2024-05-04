using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace HW3.Task4
{
    public class Spawner: MonoBehaviour, IEnemyDeathNotifier, IEnemySpawnNotifier
    {
        [SerializeField] private float _spawnCooldown;
        [SerializeField] private int _limitWeight;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private EnemyFactory _enemyFactory;

        private List<Enemy> _spawnedEnemies = new List<Enemy>();

        private Coroutine _spawn;
        private EnemyWeight _enemyWeight;

        public void StartWork(EnemyWeight enemyWeight)
        {
            _enemyWeight = enemyWeight;
            
            StopWork();

            _spawn = StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                Enemy enemy = _enemyFactory.Get((EnemyType)Random.Range(0, Enum.GetValues(typeof(EnemyType)).Length));
                SpawnNotified?.Invoke(enemy);
                enemy.MoveTo(_spawnPoints[Random.Range(0, _spawnPoints.Count)].position);
                enemy.Died += OnEnemyDied;
                _spawnedEnemies.Add(enemy);

                if (!CanSpawn()) yield break;
                
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }

        private bool CanSpawn()
        {
            if (_enemyWeight.Value < _limitWeight)
            {
                return true;
            }
            
            StopWork();
            return false;
        }

        private void OnEnemyDied(Enemy enemy)
        {
            Notified?.Invoke(enemy);
            enemy.Died -= OnEnemyDied;
            _spawnedEnemies.Remove(enemy);
        }

        public void KillRandomEnemy()
        {
            if(_spawnedEnemies.Count < 0)
                return;
            
            _spawnedEnemies[Random.Range(0, _spawnedEnemies.Count)].Kill();
        }

        public void StopWork()
        {
            if(_spawn != null)
                StopCoroutine(_spawn);
        }

        public event Action<Enemy> Notified;
        public event Action<Enemy> SpawnNotified;
    }
}