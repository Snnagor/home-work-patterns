using UnityEngine;

namespace HW3.Task2
{
    public class ElfPaladin: Enemy
    {
        protected override void Attack()
        {
            Debug.Log("Я Эльф паладин. Я атакую стрелами");
        }
    }
}