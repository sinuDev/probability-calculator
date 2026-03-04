using ProbabilityCalculatorApi.Enums;
using ProbabilityCalculatorApi.Services;
using Xunit;

namespace ProbabilityCalculator.Tests
{
    public class ProbabilityServiceTests
    {
        [Fact]
        public void CombinedWith_ReturnsCorrectResult()
        {
            var service = new ProbabilityService();

            var result = service.Calculate(0.5, 0.5, CalculationType.CombinedWith);

            Assert.Equal(0.25, result);
        }

        [Fact]
        public void Either_ReturnsCorrectResult()
        {
            var service = new ProbabilityService();

            var result = service.Calculate(0.5, 0.5, CalculationType.Either);

            Assert.Equal(0.75, result);
        }
    }
}