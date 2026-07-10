namespace FigureAreaCalculator.DataModel.Models
{
    public class TriangleFigure : FigureBase
    {
        public override string Name => "Trójkąt";
        public double BaseLenght { get; }
        public double Height { get; }
        public TriangleFigure(double baseLenght, double height)
        {
            ValidatePositive(baseLenght, nameof(baseLenght));
            ValidatePositive(height, nameof(height));
            BaseLenght = baseLenght;
            Height = height;
        }
        public override double CalculateArea()
        {
            return BaseLenght * Height/2;
        }
    }
}
