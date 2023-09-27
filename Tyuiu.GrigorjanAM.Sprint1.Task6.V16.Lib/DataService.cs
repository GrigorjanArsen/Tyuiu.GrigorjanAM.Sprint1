using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GrigorjanAM.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            string s1 = "!";
            string s2 = "?";
            if (value.Contains(s1) & value.Contains(s2))
                return true;
            else
                return false;
        }
    }
}
