using UnityEngine;

namespace HW3.Task2
{
    [CreateAssetMenu(fileName = "EnemyConfig", menuName = "Configs/EnemyConfig", order = 0)]
    public class EnemyConfig : ScriptableObject
    {
        [field: SerializeField] public ElfConfig ElfConfig { get; private set; }
        [field: SerializeField] public OrcConfig OrcConfig { get; private set; }
    }
}