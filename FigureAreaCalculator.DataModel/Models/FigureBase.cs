using FigureAreaCalculator.DataModel.Interfaces;
namespace FigureAreaCalculator.DataModel.Models
{
    public abstract class FigureBase : IFigure
    {
        public abstract string Name { get; }
        public abstract double CalculateArea();
        protected void ValidatePositive(double value, string parameterName)
        {
            if (value < 0) throw new ArgumentException($"{parameterName} musi być większe od zera.");
        }
    }
}
