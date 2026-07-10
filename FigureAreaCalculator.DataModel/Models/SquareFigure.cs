namespace FigureAreaCalculator.DataModel.Models
{
    public class SquareFigure :FigureBase
    {
        public override string Name => "Kwadrat";
        public double Side { get; }
        public SquareFigure(double side) 
        {
            ValidatePositive(side, nameof(side));
            Side = side;
        }
        public override double CalculateArea()
        {
            return Side*Side;
        }
    }
}
