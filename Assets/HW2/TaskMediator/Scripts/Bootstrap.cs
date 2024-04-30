using UnityEngine;

namespace HW2.TaskMediator
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private PlayerConfig _playerConfig;
        [SerializeField] private HealthPlayer _playerPrefab;
        [SerializeField] private UpgradePanel _upgradePanel;
        [SerializeField] private DefeatPanel _defeatPanel;
        [SerializeField] private DamagePanel _damagePanel;
        [SerializeField] private HpPanel _hpPanel;
        
        private GameplayMediator _gameplayMediator;
        private PlayerMediator _playerMediator;
        private Level _level;
        private UpgradeControl _upgradeControl;
        private HealthPlayer _player;

        private void Awake()
        {
            CreatePlayer();
            _upgradeControl = new UpgradeControl(_playerConfig, _player);
            _level = new Level(_player, _upgradeControl, _defeatPanel);
            _gameplayMediator = new GameplayMediator(_level, _upgradeControl, _defeatPanel);
            _playerMediator = new PlayerMediator(_upgradeControl, _upgradePanel, _damagePanel, _player, _hpPanel);
            _level.Start();
        }

        private void CreatePlayer()
        {
            _player = Instantiate(_playerPrefab, Vector3.zero, Quaternion.identity);
        }
    }
}