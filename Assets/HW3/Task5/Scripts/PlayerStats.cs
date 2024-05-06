using UnityEngine;

namespace HW3.Task5
{
    public class PlayerStats
    {
        public int Power { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }

        public static PlayerStats operator +(PlayerStats a, PlayerStats b)
        {
            return new PlayerStats()
            {
                Power = a.Power + b.Power,
                Agility = a.Agility + b.Agility,
                Intelligence = a.Intelligence + b.Intelligence
            };
        } 
        
        public static PlayerStats operator *(PlayerStats a, PlayerStats b)
        {
            return new PlayerStats()
            {
                Power = a.Power * b.Power,
                Agility = a.Agility * b.Agility,
                Intelligence = a.Intelligence * b.Intelligence
            };
        }
    }
}


