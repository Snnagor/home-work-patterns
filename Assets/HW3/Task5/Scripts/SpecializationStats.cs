using System;

namespace HW3.Task5
{
    public class SpecializationStats: StatsProvider
    {
        private readonly SpecializationType _specializationType;
        
        public SpecializationStats(IStatsProvider statsProvider, SpecializationType specializationType) : base(statsProvider)
        {
            _specializationType = specializationType;
        }

        public override PlayerStats GetStats()
        {
            return _statsProvider.GetStats() * GetAdditionalValueStats();
        }

        protected override PlayerStats GetAdditionalValueStats()
        {
            switch (_specializationType)
            {
                case SpecializationType.Thief:
                    return new PlayerStats()
                    {
                        Power = 1,
                        Agility = 3,
                        Intelligence = 1
                    };
                case SpecializationType.Mage:
                    return new PlayerStats()
                    {
                        Power = 1,
                        Agility = 1,
                        Intelligence = 2
                    };
                case SpecializationType.Barbarian:
                    return new PlayerStats()
                    {
                        Power = 4,
                        Agility = 1,
                        Intelligence = 1
                    };
                default:
                    throw new NotImplementedException(nameof(_specializationType));
            }
        }
    }
}