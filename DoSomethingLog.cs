namespace StrategyPattern
{
    public class DoSomethingLog
    {
        private readonly ILogger _logger;

        public DoSomethingLog(ILogger logger)
        {
            this._logger = logger;
        }

        public virtual void DoJob()
        {
            this._logger.Log("Something... ");
        }
    }
}
