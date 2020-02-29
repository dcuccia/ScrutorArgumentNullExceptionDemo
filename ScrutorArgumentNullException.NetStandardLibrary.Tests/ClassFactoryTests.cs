using System;
using NUnit.Framework;

namespace ScrutorArgumentNullException
{
    class ClassFactoryTests
    {
        [Test]
        public void run_code_that_will_fail_with_tooling()
        {
            var implementations = ClassFactory.GetAllImplementationsOfIClass();

        }
    }
}
