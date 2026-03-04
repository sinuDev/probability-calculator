namespace ProbabilityCalculatorApi.Logging
{
    public static class FileLogger
    {
        public static void Log(string calculationType, double a, double b, double result)
        {
            var log = $"{DateTime.Now} | {calculationType} | A:{a} | B:{b} | Result:{result}\n";

            File.AppendAllText("calculation_log.txt", log);
        }
    }
}