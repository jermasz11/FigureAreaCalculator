namespace FigureAreaCalculator.DataModel.Models
{
    public class CircleFigure : FigureBase
    {
        public override string Name => "Koło";
        public double Radius { get; }
        public CircleFigure(double radius) 
        {
            ValidatePositive(radius, nameof(radius));
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI*Radius*Radius;
        }
    }
}
