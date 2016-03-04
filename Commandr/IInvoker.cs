namespace Commandr
{
    public interface IInvoker
    {
        void Register(ICommand command);
        void Run();
        void Rollback();
    }
}
