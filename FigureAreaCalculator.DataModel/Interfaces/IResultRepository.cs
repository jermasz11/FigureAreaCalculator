namespace FigureAreaCalculator.DataModel.Interfaces
{
    public interface IResultRepository
    {
        void SaveResult(string figureName, double area);
    }
}
