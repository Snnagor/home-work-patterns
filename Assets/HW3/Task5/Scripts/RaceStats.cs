using System;

namespace HW3.Task5
{
    public class RaceStats: IStatsProvider
    {
        private RaceType _raceType;
        
        public RaceStats(RaceType type)
        {
            _raceType = type;
        }

        public PlayerStats GetStats()
        {
            switch (_raceType)
            {
                case RaceType.Human:
                    return new PlayerStats()
                    {
                        Power = 4,
                        Agility = 6,
                        Intelligence = 5
                    };
                case RaceType.Orc:
                    return new PlayerStats()
                    {
                        Power = 8,
                        Agility = 2,
                        Intelligence = 2
                    };
                case RaceType.Elf:
                    return new PlayerStats()
                    {
                        Power = 3,
                        Agility = 8,
                        Intelligence = 5
                    };
                default:
                    throw new NotImplementedException(nameof(_raceType));
            }
        }
    }
}