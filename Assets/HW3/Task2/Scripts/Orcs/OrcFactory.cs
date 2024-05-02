using System;
namespace HW3.Task2
{
    public class OrcFactory: EnemyFactory
    {
        private OrcConfig _orcConfig;
        
        public OrcFactory(EnemyConfig config) : base(config)
        {
            _orcConfig = config.OrcConfig;
        }
        
        public override Enemy Get(EnemyTypes type)
        {
            switch (type)
            {
                case EnemyTypes.Paladin:
                    var orcPaladin = CreateInstance(_orcConfig.OrcPaladinPrefab);
                    orcPaladin.Init(_orcConfig.LifeTime);
                    return orcPaladin;
                
                case EnemyTypes.Mage:
                    var orcMage = CreateInstance(_orcConfig.OrcMagePrefab);
                    orcMage.Init(_orcConfig.LifeTime);
                    return orcMage;
                
                default:
                    throw new ArgumentException(nameof(type)); 
            }
        }

        
    }
}