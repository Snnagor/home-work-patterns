using UnityEngine;

namespace HW3.Task3
{
    public class CoinsFactory
    {
        private Coin _coinPrefab;
        
        public CoinsFactory(Coin coinPrefab)
        {
            _coinPrefab = coinPrefab;
        }
        
        public Coin Get()
        {
            return Object.Instantiate(_coinPrefab);
        }
    }
}