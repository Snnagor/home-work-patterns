namespace HW3.Task4
{
    public class Elf: Enemy
    {
        public override void Accept(IEnemyVisitor visitor) => visitor.Visit(this);
    }
}