using System.Collections.Generic;

namespace HW1.Task4
{
    public class BurstAllBalls: GameRules
    {
        public BurstAllBalls(List<Ball> balls) : base(balls)
        {
        }
        
        public override bool CheckContinueGame()
        {
            return _balls.Count > 0;
        }

        protected override void RemoveBall(Ball ball)
        {
            _balls.Remove(ball);
        }
    }
}