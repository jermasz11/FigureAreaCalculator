namespace FigureAreaCalculator.DataModel.Models
{
    public class RectangleFigure : FigureBase
    {
        public override string Name => "Prostokąt";
        public double Width { get; }
        public double Height { get; }
        public RectangleFigure(double width, double height) 
        {
            ValidatePositive(width, nameof(width));
            ValidatePositive(height, nameof(height));
            Width = width;
            Height = height;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
