using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace SenseFramework.Applications
{
    using Core.Configuration;

    public class ApplicationFrameworkModuleInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Classes.FromAssemblyInDirectory(new AssemblyFilter(AssemblyInstaller.AssemblyDirectory))
                .BasedOn<IApplication>()
                .WithServiceAllInterfaces()
                .LifestyleTransient());

            var applications = container.ResolveAll<IApplication>();

            foreach (var application in applications)
            {
                application.RegisterServices(container);
            }
        }
    }
}