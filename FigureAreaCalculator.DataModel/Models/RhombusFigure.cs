namespace FigureAreaCalculator.DataModel.Models
{
    public class RhombusFigure : FigureBase
    {
        public override string Name => "Romb";
        public double DiagonalA { get; }
        public double DiagonalB { get; }
        public RhombusFigure(double diagonalA, double diagonalB)
        {
            ValidatePositive(diagonalA, nameof(diagonalA));
            ValidatePositive(diagonalB, nameof(diagonalB));
            DiagonalA = diagonalA;
            DiagonalB = diagonalB;
        }
        public override double CalculateArea()
        {
            return DiagonalA * DiagonalB/2;
        }
    }
}
