using System.Collections.Generic;

namespace HW1.Task4
{
    public abstract class GameRules
    {
        protected List<Ball> _balls;
        
        protected GameRules(List<Ball> balls)
        {
            _balls = new List<Ball>(balls);
        }
        
        public void BurstBall(Ball ball)
        {
            ball.Deactivate();
            RemoveBall(ball);
        }
        
        public abstract bool CheckContinueGame();
        
        protected abstract void RemoveBall(Ball ball);
    }
}