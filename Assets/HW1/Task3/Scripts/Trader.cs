using UnityEngine;

namespace HW1.Task2
{
    public class Trader : MonoBehaviour
    {
        private ITraderBehaviour _currentBehaviour;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IBayer player))
            {
                Sell(_currentBehaviour);
            }
        }

        public void SetBehaviour(ITraderBehaviour behaviour)
        {
            _currentBehaviour = behaviour;
        }

        private void Sell(ITraderBehaviour traderBehaviour)
        {
            traderBehaviour.Trade();
        }
    }
}