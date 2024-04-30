using System;
using UnityEngine;

namespace HW1.Task2
{
    public class Player : MonoBehaviour, IBayer
    {
        [SerializeField] private EnumControl.PlayerType _playerType;

        private EnumControl.PlayerType _currentPlayerType;

        public event Action<EnumControl.PlayerType> ChangePlayerTypeEvent;

        public void Init()
        {
            ChangePlayerTypeEvent?.Invoke(_playerType);
        }

        private void OnValidate()
        {
            if (_currentPlayerType != _playerType)
            {
                ChangePlayerTypeEvent?.Invoke(_playerType);
                _currentPlayerType = _playerType;
            }
        }

        public EnumControl.PlayerType PlayerType => _playerType;
    }
}

