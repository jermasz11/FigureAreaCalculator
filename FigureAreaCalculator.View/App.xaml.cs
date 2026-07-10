using Autofac;
using FigureAreaCalculator.View.ViewModels;
using System.Windows;

namespace FigureAreaCalculator.View
{
    public partial class App : Application
    {
        private IContainer? _container;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _container = Bootstraper.BuildContainer();
            var mainWindow = new MainWindow
            {
                DataContext = _container.Resolve<MainViewModel>()
            };
            mainWindow.Show();
        }
    }

}
