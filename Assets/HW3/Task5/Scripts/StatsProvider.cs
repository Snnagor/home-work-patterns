using UnityEngine;

namespace HW3.Task5
{
    public abstract class StatsProvider: IStatsProvider
    {
        protected readonly IStatsProvider _statsProvider;

        public StatsProvider(IStatsProvider statsProvider)
        {
            _statsProvider = statsProvider;
        }
        
        public virtual PlayerStats GetStats()
        {
            return GetAdditionalValueStats();
        }

        protected abstract PlayerStats GetAdditionalValueStats();
    }
}