using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MyServices.CalculationServices.Interfaces;

namespace Features
{
    public class CalculateFeature
    {
        public class Command : IRequest<CalculationResult>
        {
            public int number1 { get; set; }
            public int number2 { get; set; }
            public TypeOfCalculation CalculateType { get; set; }
            public enum TypeOfCalculation
            {
                Addition,
                Subtraction,
                Division,
                Multiply
            }
        }

        public class CalculationResult
        {
            public int Result { get; set; }
        }

        public class CalculateHandler : IRequestHandler<Command, CalculationResult>
        {

            private readonly ICalculationService _calculationService;

            public CalculateHandler(ICalculationService calculationService)
            {
                _calculationService = calculationService;
            }
            public Task<CalculationResult> Handle(Command request, CancellationToken cancellationToken)
            {
                var result = new CalculationResult();

                switch (request.CalculateType)
                {
                    case Command.TypeOfCalculation.Addition:
                        result.Result = _calculationService.Add(request.number1, request.number2);
                        break;
                    case Command.TypeOfCalculation.Subtraction:
                        result.Result = _calculationService.Subtract(request.number1, request.number2);
                        break;
                    case Command.TypeOfCalculation.Division:
                        result.Result = _calculationService.Divide(request.number1, request.number2);
                        break;
                    case Command.TypeOfCalculation.Multiply:
                        result.Result = _calculationService.Multiply(request.number1, request.number2);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                return Task.FromResult(result);
            }
        }
    }
}
