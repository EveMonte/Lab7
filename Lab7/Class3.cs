using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6;

namespace Lab7
{
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
        public WrongStringFormat(string message) : base(message)
        {

        }
    }

    class WrongNumberValue : Exception
    {
        public string message = "We Have Cars With 4 Wheels Only";
        public WrongNumberValue(string message) : base(message)
        {

        }
    }


    class NullException : ApplicationException
    {
        public string message = "Please, Don't send empty string!";
        public NullException(string message) : base(message)
        {

        }
    }
}
