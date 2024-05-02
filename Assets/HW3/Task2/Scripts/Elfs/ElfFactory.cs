using System;

namespace HW3.Task2
{
    public class ElfFactory: EnemyFactory
    {
        private ElfConfig _elfConfig;
        
        public ElfFactory(EnemyConfig config) : base(config)
        {
            _elfConfig = config.ElfConfig;
        }
        
        public override Enemy Get(EnemyTypes type)
        {
            switch (type)
            {
                case EnemyTypes.Paladin:
                    var elfPaladin = CreateInstance(_elfConfig.ElfPaladinPrefab);
                    elfPaladin.Init(_elfConfig.LifeTime);
                    return elfPaladin;
                
                case EnemyTypes.Mage:
                    var elfMage = CreateInstance(_elfConfig.ElfMagePrefab);
                    elfMage.Init(_elfConfig.LifeTime);
                    return elfMage;
                
                default:
                    throw new ArgumentException(nameof(type)); 
            }
        }
    }
}