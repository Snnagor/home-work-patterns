namespace HW3.Task4
{
    public interface IEnemyVisitor
    {
        void Visit (Elf elf);
        void Visit (Human human);
        void Visit (Orc orc);
    }
}