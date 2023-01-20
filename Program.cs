using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerDemo();
        }

        private static void LoggerDemo()
        {
            var fileLogger = new FileLogger("log.txt");
            var consoleLogger = new ConsoleLogger();
            var doSomethingImportant = new DoSomethingLog(fileLogger);
            var doSomethingLessImportant = new DoSomethingLog(consoleLogger);
            doSomethingImportant.DoJob();
            doSomethingLessImportant.DoJob();
        }
    }
}
