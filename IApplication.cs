using Castle.Windsor;
using System;
using System.Threading.Tasks;

namespace SenseFramework.Applications
{
    public interface IApplication
    {
        /// <summary>
        /// Registers applications.
        /// </summary>
        /// <param name="container">The IoC_Container.</param>
        void RegisterServices(IWindsorContainer container);
                
        void Run();
        void Run(Action action);
        void Run<T>(Action<T> action);

        Task RunAsync();
        Task RunAsync(Action action);
        Task RunAsync<T>(Action<T> action);

    }
}
