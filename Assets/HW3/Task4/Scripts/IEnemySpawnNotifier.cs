using System;

namespace HW3.Task4
{
    public interface IEnemySpawnNotifier
    {
        event Action<Enemy> SpawnNotified;
    }
}