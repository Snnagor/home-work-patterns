using System;
using UnityEngine;

namespace HW3.Task4
{
    public class Score: IDisposable
    {
        public int Value => _enemyVisitor.Score;

        private IEnemyDeathNotifier _enemyDeathNotifier;
        private EnemyVisitor _enemyVisitor;
        
        public Score(IEnemyDeathNotifier enemyDeathNotifier)
        {
            _enemyDeathNotifier = enemyDeathNotifier;
            _enemyDeathNotifier.Notified += OnEnemyKilled;

            _enemyVisitor = new EnemyVisitor();
        }

        public void OnEnemyKilled(Enemy enemy)
        {
            enemy.Accept(_enemyVisitor);
          //  Debug.Log("Счет: " + Value);
        }

        public void Dispose()
        {
            _enemyDeathNotifier.Notified -= OnEnemyKilled;
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Score { get; private set; }

            public void Visit(Elf elf) => Score += 10;

            public void Visit(Human human) => Score += 5;

            public void Visit(Orc orc) => Score += 20;
        }
    }
}