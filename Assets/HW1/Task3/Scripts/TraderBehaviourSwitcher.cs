using UnityEngine;

namespace HW1.Task2
{
    public class TraderBehaviourSwitcher : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Trader _trader;

        private void OnEnable()
        {
            _player.ChangePlayerTypeEvent += ChangeTrader;
        }

        private void OnDisable()
        {
            _player.ChangePlayerTypeEvent -= ChangeTrader;
        }

        private void ChangeTrader(EnumControl.PlayerType playerType)
        {
            switch (playerType)
            {
                case EnumControl.PlayerType.Enemy:
                    _trader.SetBehaviour(new TradeWithEnemy());
                    break;
                    
                case EnumControl.PlayerType.Warrior: 
                    _trader.SetBehaviour(new TradeWithWarrior());
                    break;
                    
                case EnumControl.PlayerType.Citizen: 
                    _trader.SetBehaviour(new TradeWithCitizen());
                    break;
            }
        }
    }
}