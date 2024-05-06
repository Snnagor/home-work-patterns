using System;

namespace HW3.Task5
{
    public class PassiveAbilityStats: StatsProvider
    {
        private readonly PassiveAbilityType _passiveAbilityType;
        
        public PassiveAbilityStats(IStatsProvider statsProvider, PassiveAbilityType passiveAbilityType) : base(statsProvider)
        {
            _passiveAbilityType = passiveAbilityType;
        }

        public override PlayerStats GetStats()
        {
            return _statsProvider.GetStats() + GetAdditionalValueStats();
        }

        protected override PlayerStats GetAdditionalValueStats()
        {
            switch (_passiveAbilityType)
            {
                case PassiveAbilityType.Tactics:
                    return new PlayerStats()
                    {
                        Power = 0,
                        Agility = 0,
                        Intelligence = 5
                    };
                case PassiveAbilityType.Hacking:
                    return new PlayerStats()
                    {
                        Power = 0,
                        Agility = 4,
                        Intelligence = 0
                    };
                case PassiveAbilityType.Leadership:
                    return new PlayerStats()
                    {
                        Power = 4,
                        Agility = 0,
                        Intelligence = 0
                    };
                default:
                    throw new NotImplementedException(nameof(_passiveAbilityType));
            }
        }
    }
}