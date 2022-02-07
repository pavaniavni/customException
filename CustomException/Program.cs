using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    public class TemperatureIsZeroException : Exception
    {
        public TemperatureIsZeroException(string message) : base(message)
        {

        }
    }

    public class TestTemperature
    {
        int temp = 0;
        public void ShowTemp()
        {
            if (temp == 0)
            {
                throw (new TemperatureIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature :{0}", temp);
            }
        }
        static void Main(string[] args)
        {
            TestTemperature testTemp = new TestTemperature();
            try
            {
                testTemp.ShowTemp();
            }
            catch (TemperatureIsZeroException e)
            {
                Console.WriteLine("Custom exception is {0}", e.Message);
            }
        }
    }
}
