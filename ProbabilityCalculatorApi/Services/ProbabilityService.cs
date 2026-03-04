using ProbabilityCalculatorApi.Enums;
using ProbabilityCalculatorApi.Logging;

namespace ProbabilityCalculatorApi.Services
{
    public class ProbabilityService : IProbabilityService
    {
        public double Calculate(double a, double b, CalculationType type)
        {
            if (a < 0 || a > 1 || b < 0 || b > 1)
            {
                throw new ArgumentException("Probability must be between 0 and 1");
            }

            double result;

            switch (type)
            {
                case CalculationType.CombinedWith:
                    result = a * b;
                    break;

                case CalculationType.Either:
                    result = a + b - (a * b);
                    break;

                default:
                    throw new ArgumentException("Invalid calculation type");
            }

            FileLogger.Log(type.ToString(), a, b, result);

            return result;
        }
    }
}