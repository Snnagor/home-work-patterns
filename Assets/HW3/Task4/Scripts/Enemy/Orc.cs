namespace HW3.Task4
{
    public class Orc: Enemy
    {
        public override void Accept(IEnemyVisitor visitor) => visitor.Visit(this);
    }
}