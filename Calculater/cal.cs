using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    public class Calculater1
    {
        public double Add(double x, double y)
        {
            double result=x+y;
            return result;
        }
        public double Sub(double x, double y)
        {
            double result=x-y;
            return result;
        }
        public double Multi(double x, double y)
        {
            double result=x*y;
            return result;
        }
        public double Div(double x, double y)
        {
            double result=x/y;
            return result;
        }
    }
}
