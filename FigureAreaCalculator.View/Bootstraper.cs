using Autofac;
using FigureAreaCalculator.DataModel.Interfaces;
using FigureAreaCalculator.DataModel.Repository;
using FigureAreaCalculator.View.ViewModels;
namespace FigureAreaCalculator.View
{
    public static class Bootstraper
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<FileResultRepository>()
                .As<IResultRepository>()
                .SingleInstance();
            builder.RegisterType<MainViewModel>();
            return builder.Build();
        }
    }
}
