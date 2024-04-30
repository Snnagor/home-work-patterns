using UnityEngine;

namespace HW1.Task2
{
    public class TradeWithEnemy: ITraderBehaviour
    {
        public void Trade()
        {
            Debug.Log("Ты враг. Я с тобой не торгую");
        }
    }
}