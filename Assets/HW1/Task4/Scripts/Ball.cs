using UnityEngine;

namespace HW1.Task4
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private BallColor _ballColor;

        public BallColor BallColor => _ballColor;

        public void Deactivate()
        {
            gameObject.SetActive(false);
        }
    }
}