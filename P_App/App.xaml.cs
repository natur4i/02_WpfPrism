using P_App.Views;
using Prism.Ioc;
using P_App.ViewModels;
using System.Windows;

namespace P_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterDialog<ViewB, ViewBViewModel>();
        }
    }
}
