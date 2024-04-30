using System;
using UnityEngine;

namespace HW2.TaskMediator 
{
    public class HealthPlayer: MonoBehaviour, IPlayer
    {
        public event Action DeathEvent;
        
        private int _maxHealth;
        public int MaxHealth => _maxHealth;
        private int _dmg;
        private int _currentHealth;
        public int CurrentHealth => _currentHealth;
        private bool _isAlive;

        public void SetLevel(int maxHealth, int dmg)
        {
            _maxHealth = maxHealth;
            _dmg = dmg;
            Default();
        }

        public void Damage()
        {
            if(!_isAlive)
                return;
            
            _currentHealth -= _dmg;

            Death();
        }

        private void Death()
        {
            if (_currentHealth > 0) 
                return;
            
            _isAlive = false;
            _currentHealth = 0;
            DeathEvent?.Invoke();
        }

        private void Default()
        {
            _isAlive = true;
            _currentHealth = _maxHealth;
        }
    }
}