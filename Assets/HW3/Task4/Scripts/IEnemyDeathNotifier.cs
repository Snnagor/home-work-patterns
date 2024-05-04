using System;

namespace HW3.Task4
{
    public interface IEnemyDeathNotifier
    {
        event Action<Enemy> Notified;
    }
}