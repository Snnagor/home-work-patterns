using System;
using UnityEngine;

namespace HW1.Task2
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private Player _player;

        private void Start()
        {
            _player.Init();
        }
    }
}