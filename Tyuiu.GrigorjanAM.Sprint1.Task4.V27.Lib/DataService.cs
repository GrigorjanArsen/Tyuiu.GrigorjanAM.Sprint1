using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;


namespace Tyuiu.GrigorjanAM.Sprint1.Task4.V27.Lib
{
    public class DataService : ISprint1Task4V27
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round((1 + Math.Sin(x * Math.PI)) / (x - Math.Sqrt(Math.Abs(y))),3);

            return res;
        }
    }
}
