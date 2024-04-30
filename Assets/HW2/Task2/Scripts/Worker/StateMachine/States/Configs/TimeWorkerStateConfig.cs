using System;
using UnityEngine;

namespace HW2.Task2.Configs
{
    [Serializable]
    public class TimeWorkerStateConfig
    {
        [field: SerializeField] public float RestTime { get; private set; }
        [field: SerializeField] public float WorkingTime { get; private set; }
    }
}