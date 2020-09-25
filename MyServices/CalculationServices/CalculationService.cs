using MyServices.CalculationServices.Interfaces;

namespace MyServices.CalculationServices
{
    public class CalculationService : ICalculationService
    {
        public int Add(int number1, int number2) => number1 + number2;

        public int Subtract(int original, int subtractAmount) => original - subtractAmount;

        public int Divide(int original, int divideBy) => original / divideBy; // TODO: Maybe add an try catch to not get a nasty divide by zero exception.

        public int Multiply(int original, int multiplier) => original * multiplier;
    }
}
