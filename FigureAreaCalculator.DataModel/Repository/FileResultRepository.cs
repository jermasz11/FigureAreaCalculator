using FigureAreaCalculator.DataModel.Interfaces;
namespace FigureAreaCalculator.DataModel.Repository
{
    public class FileResultRepository : IResultRepository
    {
        private readonly string _filePath = "result.txt";
        public void SaveResult(string figureName, double area)
        {
            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}; Figura: {figureName}; Pole: {area:F2}";
            File.AppendAllLines(_filePath, new[] {line});
        }
    }
}
