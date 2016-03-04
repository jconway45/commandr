using Commandr;
using Moq;
using NUnit.Framework;

namespace Commandr.Tests
{
    [TestFixture]
    public class InvokerTests
    {
        [Test]
        public void Registers_and_runs_commands()
        {
            var mockInvoker1 = new Mock<ICommand>();
            mockInvoker1.Setup(x => x.Execute());

            var mockInvoker2 = new Mock<ICommand>();
            mockInvoker2.Setup(x => x.Execute());

            var invoker = new Invoker();
            invoker.Register(mockInvoker1.Object);
            invoker.Register(mockInvoker2.Object);

            invoker.Run();

            mockInvoker1.VerifyAll();
            mockInvoker2.VerifyAll();
        }
    }
}
