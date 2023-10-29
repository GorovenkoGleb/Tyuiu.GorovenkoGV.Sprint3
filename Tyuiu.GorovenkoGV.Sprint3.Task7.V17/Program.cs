using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorovenkoGV.Sprint3.Task7.V17.Lib;

namespace Tyuiu.GorovenkoGV.Sprint3.Task7.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Горовенко Г.В. | ПКТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Горовенко Глеб Васильевич | ПКТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* (((Math.Sin(x) / x + 1.7) - ( Math.Cos(x) * (4 * x) - 6)))              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");


            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Страт шага  = " + startValue);
            Console.WriteLine("Конец шага  = " + stopValue);


            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] vallueArray;
            vallueArray = new double[len];

            vallueArray = ds.GetMassFunction(startValue, stopValue);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+---------------+");
            Console.WriteLine("+     X    +    f(x)       +");
            Console.WriteLine("+----------+---------------+");
            for (int i = 0; i <=len-1; i++)
            {
                Console.WriteLine("| {0,5:d}    | {1, 5:f2}         |", startValue, vallueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+---------------+");
            Console.ReadKey();
        }
    }
}
