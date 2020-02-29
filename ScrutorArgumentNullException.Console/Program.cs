using System;

namespace ScrutorArgumentNullException
{
    class Program
    {
        static void Main(string[] args)
        {
            var implementations = ClassFactory.GetAllImplementationsOfIClass();

            foreach (var implementation in implementations)
            {
                Console.WriteLine(implementation);
            }
        }
    }
}
