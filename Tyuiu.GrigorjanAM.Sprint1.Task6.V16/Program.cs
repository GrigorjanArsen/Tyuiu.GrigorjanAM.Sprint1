using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorjanAM.Sprint1.Task6.V16.Lib;
namespace Tyuiu.GrigorjanAM.Sprint1.Task6.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Григорян А. М. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Григорян Арсен Мовсесович | ИИПБ-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая принимает на вход строку,                   *");
            Console.WriteLine("* а затем выясняет, есть ли в ней '!' и '?                                *");
            
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string x;

            Console.WriteLine("Введите строку, чтобы проверить, есть ли в ней знаки '!' и '?' :");
            x = Convert.ToString(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckSpecSymbols(x) == true)
                Console.WriteLine("В строке есть оба знака '!' и '?'");
            else if (x.Contains("!"))
                Console.WriteLine("В строке есть только знак '!'");
            else if (x.Contains("?"))
                Console.WriteLine("В строке есть только знак '?'");
            else
                Console.WriteLine("В строке нет обоих знаков '!' и '?'");
            Console.ReadKey();
        }
    }
}
