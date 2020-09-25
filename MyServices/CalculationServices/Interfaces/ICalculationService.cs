namespace MyServices.CalculationServices.Interfaces
{

    /// <summary>
    /// Basic service to allow basic arithmetic calculations
    /// </summary>
    public interface ICalculationService
    {
        /// <summary>
        /// Adds two numbers together and returns the result of the addition
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        int Add(int number1, int number2);
        int Subtract(int original, int subtractAmount);
        int Divide(int original, int divideBy);
        int Multiply(int original, int multiplier);

    }
}
