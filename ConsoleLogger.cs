using System;

namespace StrategyPattern
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
        }

        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.UtcNow} - {message}");
        }
    }
}
