using System;
using System.Collections.Generic;
using System.Text;

namespace LogServices
{
    public  class ConsoleLogProvider:ILogProvider
    {
        public void LogError(string msg)
        {
            Console.WriteLine($"Error {msg} ");
        }

        public void LogInfo(string msg)
        {
            Console.WriteLine($"info {msg}");
        }
    }
}
