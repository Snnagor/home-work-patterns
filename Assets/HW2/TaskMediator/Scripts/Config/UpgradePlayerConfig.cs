using System;
using UnityEngine;

namespace HW2.TaskMediator
{
    [Serializable]
    public class UpgradePlayerConfig
    {
        [field: SerializeField] public string LevelName { get; private set; }
        [field: SerializeField, Range(0, 200)] public int MaxHealth { get; private set; }
        [field: SerializeField, Range(0, 50)] public int Damage { get; private set; }
    }
}