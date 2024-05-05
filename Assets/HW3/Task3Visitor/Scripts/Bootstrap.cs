using System.Collections.Generic;
using UnityEngine;

namespace HW3.Task3
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Coin _coinPrefab;
        [SerializeField] private List<Transform> _spawnPoints;
        [SerializeField] private float _spawnCooldown;

        private Spawner _spawner;
        private CoinsFactory _coinsFactory;

        private void Awake()
        {
            _coinsFactory = new CoinsFactory(_coinPrefab);
            _spawner = new Spawner(_spawnPoints, _spawnCooldown, _coinsFactory, this);
            _spawner.StartWork();
        }
    }
}