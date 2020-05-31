using System;

namespace InfrastuctureLayer
{
    public class Logger
    {
        public void Info(string details)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"INFO: {details}");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
        }
    }
}