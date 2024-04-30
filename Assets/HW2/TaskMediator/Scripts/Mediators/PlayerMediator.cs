using System;

namespace HW2.TaskMediator
{
    public class PlayerMediator: IDisposable
    {
        private readonly UpgradeControl _upgradeControl;
        private readonly UpgradePanel _upgradePanel;
        private readonly DamagePanel _damagePanel;
        private readonly IPlayer _healthPlayer;
        private readonly HpPanel _hpPanel;
        
        public PlayerMediator(
            UpgradeControl upgradeControl,
            UpgradePanel upgradePanel,
            DamagePanel damagePanel,
            IPlayer healthPlayer,
            HpPanel hpPanel
        )
        {
            _upgradePanel = upgradePanel;
            _upgradePanel.LevelUpEvent += OnLevelUp;
            _upgradeControl = upgradeControl;
            _upgradeControl.LevelDefaultEvent += OnLevelDefault;
            _damagePanel = damagePanel;
            _damagePanel.DamageEvent += OnDamage;
            _healthPlayer = healthPlayer;
            _healthPlayer.DeathEvent += UpdateHpUI;
            _hpPanel = hpPanel;
        }

        public void Dispose()
        {
            _upgradePanel.LevelUpEvent -= OnLevelUp;
            _upgradeControl.LevelDefaultEvent -= OnLevelDefault;
            _damagePanel.DamageEvent -= OnDamage;
            _healthPlayer.DeathEvent -= UpdateHpUI;
        }
        
        private void OnLevelDefault()
        {
            UpdateAllUI();
        }

        private void UpdateAllUI()
        {
            _upgradePanel.UpdateLevelTitle(_upgradeControl.GetTitleLevel());
            _damagePanel.UpdateDamageUI(_upgradeControl.GetDamageValue());
            UpdateHpUI();
        }

        private void OnLevelUp()
        {
            _upgradeControl.LevelUp();
            UpdateAllUI();
        }
        
        private void UpdateHpUI()
        {
            _hpPanel.UpdateValue(_healthPlayer.CurrentHealth, _healthPlayer.MaxHealth);
        }

        private void OnDamage()
        {
            _healthPlayer.Damage();
            UpdateHpUI();
        }
    }
}