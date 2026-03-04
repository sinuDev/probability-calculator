using ProbabilityCalculatorApi.Enums;

namespace ProbabilityCalculatorApi.Services
{
    public interface IProbabilityService
    {
        double Calculate(double a, double b, CalculationType type);
    }
}