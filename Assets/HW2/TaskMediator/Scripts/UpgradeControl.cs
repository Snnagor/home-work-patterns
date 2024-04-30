using System;

namespace HW2.TaskMediator
{
    public class UpgradeControl
    {
        public event Action LevelDefaultEvent;
        
        private readonly PlayerConfig _playerConfig;
        private readonly IPlayer _player;
        private int _currentIdLevel;
        
        public UpgradeControl(PlayerConfig playerConfig, IPlayer player)
        {
            _playerConfig = playerConfig;
            _player = player;
        }

        public void SetLevelDefault()
        {
            _currentIdLevel = 0;
            SetLevel();
            LevelDefaultEvent?.Invoke();
        }

        public void LevelUp()
        {
            if (_currentIdLevel == _playerConfig.UpgradeLevels.Length - 1)
                return;

            _currentIdLevel++;
            SetLevel();
        }

        public string GetTitleLevel() => _playerConfig.UpgradeLevels[_currentIdLevel].LevelName;
        public int GetDamageValue() =>_playerConfig.UpgradeLevels[_currentIdLevel].Damage;

        private void SetLevel()
        {
            var maxHealth = _playerConfig.UpgradeLevels[_currentIdLevel].MaxHealth;
            var dmg = GetDamageValue();

            _player.SetLevel(maxHealth, dmg);
        }
    }
}