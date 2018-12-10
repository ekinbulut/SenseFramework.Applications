namespace SenseFramework.Applications
{
    using Core.Integrations;
    using Core.IoC;
    using Core.Messaging;

    public class ApplicationFrameworkModule : ITierApplicationModule
    {
        public void RegisterModule()
        {
            Messanger.Logger.Info("Application Module Installing...");

            IoCManager.Container.Install(new ApplicationFrameworkModuleInstaller());

            Messanger.Logger.Info("Application Module Installed...");

        }
    }
}
