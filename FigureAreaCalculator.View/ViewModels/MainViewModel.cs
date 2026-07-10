using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using FigureAreaCalculator.DataModel.Interfaces;
using FigureAreaCalculator.DataModel.Models;
using FigureAreaCalculator.View.Commands;
namespace FigureAreaCalculator.View.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IResultRepository _resultRepository;
        public MainViewModel(IResultRepository resultRepository)
        {
            _resultRepository = resultRepository;
            Figures = new List<string>
            {
                "Prostokąt",
                "Kwadrat",
                "Trójkąt",
                "Koło",
                "Romb"
            };
            CalculateCommand = new RelayCommand(Calculate);
        }
        public List<string> Figures { get; }
        private string? _selectedFigure;
        public string? SelectedFigure
        {
            get => _selectedFigure;
            set
            {
                _selectedFigure = value;
                OnPropertyChanged();
            }
        }
        public double ParameterA { get; set; }
        public double ParameterB { get; set; }
        private string? _result;
        public string? Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }
        public ICommand CalculateCommand { get; }
        private void Calculate()
        {
            try
            {
                IFigure figure = SelectedFigure switch
                {
                    "Prostokąt" => new RectangleFigure(ParameterA, ParameterB),
                    "Kwadrat" => new SquareFigure(ParameterA),
                    "Trójkąt" => new TriangleFigure(ParameterA, ParameterB),
                    "Koło" => new CircleFigure(ParameterA),
                    "Romb" => new RhombusFigure(ParameterA, ParameterB),
                    _ => throw new InvalidOperationException("Nie wybrano figury.")
                };
                double area = figure.CalculateArea();
                Result = $"Pole figury {figure.Name} wynosi: {area:F2}";
                _resultRepository.SaveResult(figure.Name, area);
            }
            catch (Exception ex)
            {
                Result = ex.Message;
            }
        }
    }
}
