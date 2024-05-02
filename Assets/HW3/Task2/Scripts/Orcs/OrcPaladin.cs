using UnityEngine;

namespace HW3.Task2
{
    public class OrcPaladin: Enemy
    {
        protected override void Attack()
        {
            Debug.Log("Я орк паладиню. Аттакую мечем");
        }
    }
}