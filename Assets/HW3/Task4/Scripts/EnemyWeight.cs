using System;
using UnityEngine;

namespace HW3.Task4
{
    public class EnemyWeight: IDisposable
    {
        public int Value => _enemyVisitor.Weight;
        
        private EnemyVisitor _enemyVisitor;
        
        private IEnemySpawnNotifier _enemySpawnNotifier;
        
        public EnemyWeight(IEnemySpawnNotifier enemySpawnNotifier)
        {
            _enemySpawnNotifier = enemySpawnNotifier;
            _enemySpawnNotifier.SpawnNotified += OnEnemySpawn;

            _enemyVisitor = new EnemyVisitor();
        }
        
        public void Dispose()
        {
            _enemySpawnNotifier.SpawnNotified -= OnEnemySpawn;
        }

        private void OnEnemySpawn(Enemy enemy)
        {
            enemy.Accept(_enemyVisitor);
            Debug.Log("Вес: " + Value);
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Weight { get; private set; }

            public void Visit(Elf elf) => Weight += 50;

            public void Visit(Human human) => Weight += 70;

            public void Visit(Orc orc) => Weight += 100;
        }
    }
}