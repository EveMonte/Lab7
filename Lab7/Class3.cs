using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6;
using System.IO;

namespace Lab7
{
    
    public class ConsoleLogger
    {
        public void OutputInfo(string info)
        {
            Console.WriteLine(DateTime.Now + $", {info}: Test log message.");
        }
    }

    public class FileLogger
    {

        public void OutputInfo(string info)
        {
            string path = @"C:\Users\User\Desktop\ООП\Lab7\Lab7\LogFile.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(DateTime.Now + $", {info}: Test log message.");
            Console.WriteLine("Log written");
            sw.Close();
        }
    }
    public class ClassForExceptions
    {
        public string model;
        public int wheels;
        public void IsTheStringCorrect()
        {
            if (model == "Geely")
            {
                throw new WrongStringFormat("Wrong String Format!");
            }
        }
        public void IsTheNumberCorrect()
        {
            if (wheels != 4)
            {
                throw new WrongNumberValue("Wrong Number Value!");
            }
        }
    }
    class WrongStringFormat : Exception
    {
        public string message = "Your String Has Wrong Format! Please Try Again!";
        public string diagnostics = "Please, don't write \"Geely\"";
        public WrongStringFormat(string message) : base(message)
        {

        }
    }

    class WrongNumberValue : Exception
    {
        public string message = "We Have Cars With 4 Wheels Only";
        public string diagnostics = "Don't ask us for 4 wheels cars";
        public WrongNumberValue(string message) : base(message)
        {

        }
    }


    class NullException : ApplicationException
    {
        public string diagnostics = "Ummm... Just Delete This Exception. It Doesn't Matter";
        public string message = "Please, Don't send empty string!";
        public NullException(string message) : base(message)
        {

        }
    }
}
