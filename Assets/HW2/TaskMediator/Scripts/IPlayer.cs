using System;

namespace HW2.TaskMediator
{
    public interface IPlayer
    {
        public int CurrentHealth { get; }
        
        public int MaxHealth { get; }
        
        public event Action DeathEvent;
        
        public void SetLevel(int maxHealth, int dmg);
        
        public void Damage();
    }
}