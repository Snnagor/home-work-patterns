using System;

namespace HW2.TaskMediator
{
    public class Level: IDisposable
    {
        public event Action DefeatEvent;

        private readonly IPlayer _player;
        private readonly DefeatPanel _defeatPanel;
        private UpgradeControl _upgradeControl;

        public Level(IPlayer player, UpgradeControl upgradeControl,
            DefeatPanel defeatPanel)
        {
            _player = player;
            _defeatPanel = defeatPanel;
            _upgradeControl = upgradeControl;
            _player.DeathEvent += OnDefeat;
        }
        
        public void Dispose()
        {
            _player.DeathEvent -= OnDefeat;
        }
        
        public void Start()
        {
            _upgradeControl.SetLevelDefault();
        }

        public void Restart()
        {
            Start();
        }

        private void OnDefeat()
        {
            DefeatEvent?.Invoke();
        }
    }
}