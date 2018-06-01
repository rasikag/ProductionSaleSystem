using System;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace CastleWindsorTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();
            container.Register(Component.For<ICompositionRoot>().
                                         ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().
                                         ImplementedBy<ConsoleWriter>());
            container.Register(Component.For<ISingletonDemo>().
                                         ImplementedBy<SingletonDemo>());
            var root = container.Resolve<ICompositionRoot>();

            root.LogMessage("This is simple message");
            Console.ReadLine();
        }
    }       
}
