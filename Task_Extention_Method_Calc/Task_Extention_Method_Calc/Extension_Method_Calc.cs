using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Extention_Method_Calc
{
     static class Extension_Method_Calc
    {
        public static double add(this double x , double y) => x + y;
        public static double sub(this double x , double y) => x - y;
        public static double mul(this double x , double y) => x * y;
        public static double div(this double x, double y) 
        {
            if (y == 0) throw new DivideByZeroException("Can not divider by zero"); 
            return x / y;
        }
    }
}
