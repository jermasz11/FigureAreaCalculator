namespace FigureAreaCalculator.DataModel.Interfaces
{
    public interface IFigure
    {
        string Name { get; }
        double CalculateArea();
    }
}
