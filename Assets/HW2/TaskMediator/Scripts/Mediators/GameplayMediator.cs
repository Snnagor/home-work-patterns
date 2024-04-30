using System;

namespace HW2.TaskMediator
{
    public class GameplayMediator: IDisposable
    {
        private readonly Level _level;
        private readonly UpgradeControl _upgradeControl;
        private readonly DefeatPanel _defeatPanel;

        public GameplayMediator(
            Level level, 
            UpgradeControl upgradeControl, 
            DefeatPanel defeatPanel
            )
        {
            _level = level;
            _level.DefeatEvent += OnLevelDefeat;
            _defeatPanel = defeatPanel;
            _defeatPanel.Hide();
            _defeatPanel.RestartEvent += OnDefeatPanelRestart;
            _upgradeControl = upgradeControl;
        }

        public void Dispose()
        {
            _level.DefeatEvent -= OnLevelDefeat;
            _defeatPanel.RestartEvent -= OnDefeatPanelRestart;
        }

        private void OnDefeatPanelRestart()
        {
            _level.Restart();
            _defeatPanel.Hide();
        }

        private void OnLevelDefeat()
        {
            _defeatPanel.Show();
        }
    }
}