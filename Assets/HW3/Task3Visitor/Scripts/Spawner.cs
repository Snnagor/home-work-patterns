using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HW3.Task3
{
    public class Spawner
    {
        private readonly List<Transform> _spawnPoints;
        private readonly float _spawnCooldown;
        private readonly MonoBehaviour _coroutine;
        private readonly CoinsFactory _coinsFactory;
        private Coroutine _spawn;

        public Spawner(List<Transform> spawnPoints, float spawnCooldown, CoinsFactory coinsFactory, MonoBehaviour coroutine)
        {
            _spawnPoints = new List<Transform>(spawnPoints);
            _spawnCooldown = spawnCooldown;
            _coroutine = coroutine;
            _coinsFactory = coinsFactory;
        }
        
        public void StartWork()
        {
            StopWork();

            _spawn = _coroutine.StartCoroutine(Spawn());
        }

        private void StopWork()
        {
            if(_spawn != null)
                _coroutine.StopCoroutine(_spawn);
        }

        private IEnumerator Spawn()
        {
            while (true)
            {
                if (_spawnPoints.Count == 0)
                {
                    StopWork();
                    yield break;
                }
                
                Coin instance = _coinsFactory.Get();
                int randomId = Random.Range(0, _spawnPoints.Count);
                Vector3 position = _spawnPoints[randomId].position;
                _spawnPoints.RemoveAt(randomId);
                instance.Init(position);
                yield return new WaitForSeconds(_spawnCooldown);
            }
        }
    }
}