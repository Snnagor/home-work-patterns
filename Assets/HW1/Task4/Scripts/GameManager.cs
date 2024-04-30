using System;
using System.Collections.Generic;
using UnityEngine;

namespace HW1.Task4
{
    public enum BallColor
    {
        White,
        Red,
        Green
    }

    public class GameManager : MonoBehaviour
    {
        [SerializeField] private List<Ball> _allBalls = new List<Ball>();

        public event Action EndGameEvent;

        private ClickControl _clickControl;
        private GameRules _currentGame;

        private bool _startGame;

        private void Start()
        {
            _clickControl = new ClickControl();
            Init();
        }

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                if (!_startGame) return;

                 var selectBall = _clickControl.CreateClick();

                if (selectBall == null) return;

                _currentGame.BurstBall(selectBall);

                CheckEndGame();
            }
        }
        
        public void StartGameAllBalls()
        {
            _startGame = true;
            _currentGame = new BurstAllBalls(_allBalls);
            Init();
        }

        public void StartGameColorBalls()
        {
            _startGame = true;
            _currentGame = new BurstOneColorBalls(_allBalls);
            Init();
        }
        
        private void Init()
        {
            EnableBalls(_allBalls);
        }
        
        private void EnableBalls(List<Ball> balls)
        {
            if (balls.Count == 0) return;

            foreach (var item in balls)
            {
                item.gameObject.SetActive(true);
            }
        }

        private void CheckEndGame()
        {
            if (_currentGame.CheckContinueGame()) return;
            
            _startGame = false;
            EndGameEvent.Invoke();
        }
    }
}