using FluentAssertions;
using MyServices.CalculationServices;
using NUnit.Framework;

namespace UnitTests
{
    public class Tests
    {
        //TODO: Also add unit tests of mediators handler.
        private CalculationService _calculationService;
        
        [SetUp]
        public void Setup()
        {
            _calculationService = new CalculationService();
        }

        [Test]
        public void Should_AddNormally_WhenTwoPositiveNumbers()
        {
            var result = _calculationService.Add(10, 33);
            result.Should().Be(43);
        }

        [Test]
        public void Should_AddNormallyButInfactSubtract_WhenSecondNumberIsNegative()
        {
            var result = _calculationService.Add(30, -10);
            result.Should().Be(20);
        }

        [Test]
        public void Should_AddResultBeMoreNegative_WhenBothAreNegative()
        {
            var result = _calculationService.Add(-50, -50);
            result.Should().Be(100);
        }

        [Test]
        public void Should_SubtractNormally_WhenPositiveNumbers()
        {
            var result = _calculationService.Subtract(13, 3);
            result.Should().Be(10);
        }

        [Test]
        public void Should_SubtractIncreaseResult_WhenSubtractAmountIsNegative()
        {
            var result = _calculationService.Subtract(13, -3);
            result.Should().Be(16);
        }


        [Test]
        public void Should_SubtractDecreaseNegativeNumber_WhenBothAreNegatives()
        {
            var result = _calculationService.Subtract(-50, -25);
            result.Should().Be(-25);
        }

        //TODO:
        //Multiply and division tests.
    }
}