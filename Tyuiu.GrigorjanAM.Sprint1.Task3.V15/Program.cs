using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GrigorjanAM.Sprint1.Task3.V15.Lib;
namespace Tyuiu.GrigorjanAM.Sprint1.Task3.V15
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Григорян Арсен Мовсесович | ИИПБ-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* и решает следующую задачу: два автомобиля имеют скорости V1 км/ч        *");
            Console.WriteLine("* и V2 км/ч соответственно, находятся на расстоянии S км друг от друга    *");
            Console.WriteLine("* и движутся в противоположные стороны. Определить расстояние между ними  *");
            Console.WriteLine("* через T часов.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            
            
            
            Console.WriteLine("Введите скорость первого автомобиля:");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость второго автомобиля:");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время движения автомобилей:");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите начальное расстояние между автомобилями:");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Расстояние между автомобилями с указанными условиями задачи: " + ds.DistanceOverTime(v1,v2,s,t));

            Console.ReadKey();
        }
    }
}
