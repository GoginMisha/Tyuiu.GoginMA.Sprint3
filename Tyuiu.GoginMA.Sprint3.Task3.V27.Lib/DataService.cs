using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.GoginMA.Sprint3.Task3.V27.Lib
{
    public class DataService : ISprint3Task3V27
    {
        public int ConvertStringToInt(string value)
        {
            string digit = "";
            foreach (char chr in value)
            {
                if (char.IsDigit(chr))
                {
                    digit += chr;
                }
            }
            int number = Int32.Parse(digit);
            return number;
        }
    }
}