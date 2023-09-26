using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GrigorjanAM.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double b = x;
            b = x - Math.Floor(x);
            var c = Convert.ToString(b);
            c = c.Substring(2, 1);
            var d = Convert.ToInt32(c);
            return d;
        }
    }
}
