using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StrategyPattern
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            this._filePath = filePath;
        }

        public void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                sw.WriteLine(message);
                sw.Close();
            }
        }
    }
}
