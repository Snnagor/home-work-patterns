using System;
using UnityEngine;

namespace HW3.Task2
{
    [Serializable]
    public class OrcConfig
    {
        [field: SerializeField] public OrcPaladin OrcPaladinPrefab { get; private set; }
        [field: SerializeField] public OrcMage OrcMagePrefab { get; private set; }
        [field: SerializeField] public float LifeTime { get; private set; }
    }
}