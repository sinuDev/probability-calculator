using ProbabilityCalculatorApi.Enums;

namespace ProbabilityCalculatorApi.Models
{
    public class ProbabilityRequest
    {
        public double ProbabilityA { get; set; }

        public double ProbabilityB { get; set; }

        public CalculationType CalculationType { get; set; }
    }
}