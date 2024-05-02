using System;
using UnityEngine;

namespace HW3.Task2
{
    [Serializable]
    public class ElfConfig
    {
        [field: SerializeField] public ElfPaladin ElfPaladinPrefab { get; private set; }
        [field: SerializeField] public ElfMage ElfMagePrefab { get; private set; }
        [field: SerializeField] public float LifeTime { get; private set; }
    }
}