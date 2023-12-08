using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._5
{
    public class Converter
    {
        public static int Metod(double x)
        {
            if (x >= 100.7)
            {
                return 1000;
            }
            else if (x > 0 && x < 100.7)
            {
                return (int)x;
            }
            else if (x == 0)
            {
                throw new ArgumentException("Аргумент не может быть нулём");
            }
            else if (x >= -30.4 && x < 0)
            {
                return (int)x - 5;
            }
            else
            {
                return -2000;
            }
        }
    }
}
