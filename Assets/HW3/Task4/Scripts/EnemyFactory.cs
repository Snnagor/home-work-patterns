using System;
using UnityEngine;

namespace HW3.Task4
{
    [CreateAssetMenu (fileName = "VisitorEnemyFactory", menuName = "Factory/VisitorEnemyFactory")]
    public class EnemyFactory : ScriptableObject
    {
        [SerializeField] private Human _humanPrefab;
        [SerializeField] private Orc _orcPrefab;
        [SerializeField] private Elf _elfPrefab;
        
        public Enemy Get(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Elf:
                    return Instantiate(_elfPrefab);
                
                case EnemyType.Human:
                    return Instantiate(_humanPrefab);
                
                case EnemyType.Orc:
                    return Instantiate(_orcPrefab);
                
                default:
                    throw new ArgumentException(nameof(type));
            }
        }
    }
}