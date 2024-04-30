using System.Collections.Generic;

namespace HW1.Task4
{
    public class BurstOneColorBalls: GameRules
    {
        private BallColor _selectBallColor;
        
        public BurstOneColorBalls(List<Ball> balls) : base(balls)
        {
        }
        
        public override bool CheckContinueGame()
        {
            return _balls.Find(item => item.BallColor == _selectBallColor);
        }

        protected override void RemoveBall(Ball ball)
        {
            _selectBallColor = ball.BallColor;
            _balls.Remove(ball);
        }
    }
}