using System;
using UnityEngine;

namespace HW2.Task2.Configs
{
    [Serializable]
    public class MoveWorkerStateConfig
    {
        [field: SerializeField, Range(0, 10)] public float Speed { get; private set; }
    }
}