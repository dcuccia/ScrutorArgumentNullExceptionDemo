using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ScrutorArgumentNullException
{
    [TestClass]
    public class ClassFactoryTests
    {
        [TestMethod]
        public void run_code_that_will_fail_with_tooling()
        {
            var implementations = ClassFactory.GetAllImplementationsOfIClass();
        }
    }
}
