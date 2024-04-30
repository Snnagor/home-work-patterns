using UnityEngine;

namespace HW2.TaskMediator
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig", order = 0)]
    public class PlayerConfig : ScriptableObject
    {
        [field: SerializeField] public UpgradePlayerConfig[] UpgradeLevels { get; private set; }
    }
}