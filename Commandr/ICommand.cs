namespace Commandr
{
    public interface ICommand
    {
        void Execute();
        void Rollback();
        void Log();
    }
}
