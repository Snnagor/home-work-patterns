using HW2.Task2.Configs;
using UnityEngine;

namespace HW2.Task2.Config
{
    [CreateAssetMenu(fileName = "WorkerConfig", menuName = "Configs/WorkerConfig", order = 0)]
    public class WorkerConfig : ScriptableObject
    {
        [field: SerializeField] public MoveWorkerStateConfig MoveStateConfig { get; private set; }
        [field: SerializeField] public TimeWorkerStateConfig TimeStateConfig { get; private set; }
    }
}