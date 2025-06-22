using System;

namespace SingletonPatternExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            logger1.Log("This is the Fist log message.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("This is the Second log message.");

            if (logger1 == logger2)
            {
                Console.WriteLine("Both instances are same.");
            }
            else Console.WriteLine("Both instances are not same.");
        }
    }
}