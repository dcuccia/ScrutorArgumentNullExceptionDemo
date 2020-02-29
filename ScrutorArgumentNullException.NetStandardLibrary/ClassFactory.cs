using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace ScrutorArgumentNullException
{
    public static class ClassFactory
    {
        public static IClass[] GetAllImplementationsOfIClass()
        {
            var collection = new ServiceCollection()
                .Scan(scan =>
                    scan.FromApplicationDependencies()
                        .AddClasses(classes => classes.AssignableTo<IClass>())
                        .AsSelfWithInterfaces()
                        .WithTransientLifetime()
                );

            Console.WriteLine(collection);

            var serviceProvider = collection.BuildServiceProvider();

            Console.WriteLine(serviceProvider);

            return serviceProvider.GetServices<IClass>().ToArray();
        }
    }
}
