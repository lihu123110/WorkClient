//using Microsoft.Practices.Prism.MefExtensions;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
namespace ClientOA
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new AggregateModuleCatalog();
        }

        //protected override void ConfigureModuleCatalog()
        //{
        //    // Module A is defined in the code.
        //    Type moduleAType = typeof(ModuleA);
        //    ModuleCatalog.AddModule(new ModuleInfo(moduleAType.Name, moduleAType.AssemblyQualifiedName));

        //    // Module C is defined in the code.
        //    Type moduleCType = typeof(ModuleC);
        //    ModuleCatalog.AddModule(new ModuleInfo()
        //    {
        //        ModuleName = moduleCType.Name,
        //        ModuleType = moduleCType.AssemblyQualifiedName,
        //        InitializationMode = InitializationMode.OnDemand
        //    });

        //    // Module B and Module D are copied to a directory as part of a post-build step.
        //    // These modules are not referenced in the project and are discovered by inspecting a directory.
        //    // Both projects have a post-build step to copy themselves into that directory.
        //    DirectoryModuleCatalog directoryCatalog = new DirectoryModuleCatalog() { ModulePath = @".\DirectoryModules" };
        //    ((AggregateModuleCatalog)ModuleCatalog).AddCatalog(directoryCatalog);

        //    // Module E and Module F are defined in configuration.
        //    ConfigurationModuleCatalog configurationCatalog = new ConfigurationModuleCatalog();
        //    ((AggregateModuleCatalog)ModuleCatalog).AddCatalog(configurationCatalog);
        //}

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }
    }
}
