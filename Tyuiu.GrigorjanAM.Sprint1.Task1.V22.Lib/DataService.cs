using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GrigorjanAM.Sprint1.Task1.V22.Lib
{
    public class DataService : ISprint1Task1V22
    {
        public double Calculate(double x, double y)
        {
            return (5 + x) / (y * x);
        }
    }
}
