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
        public string Model;
        public void IsTheStringCorrect()
        {
            if (Model == "Geely")
            {
                throw new WrongStringFormat("Wrong String Format!");
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

    class WrongAgeValue : ArgumentOutOfRangeException
    {
        int Value { get; set; }
        public WrongAgeValue(string message, int value) : base(message)
        {
            Value = value;

        }
    }


    class IsNotWeapon : ArgumentException
    {
        string Value { get; set; }
        public IsNotWeapon(string message, string value) : base(message)
        {
            Value = value;

        }
    }
}
