using UnityEngine;

namespace HW3.Task5
{
    public class Player : MonoBehaviour
    {
        private IStatsProvider _statsProvider;

        public void Init(IStatsProvider statsProvider)
        {
            _statsProvider = statsProvider;
        }
    }
}