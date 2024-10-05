using Tyuiu.TsarevDI.Sprint2.Task2.V3.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task2.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема: ператор if – полная и короткая форма записи                     *");
            Console.WriteLine("* Задание #2                                                            *");
            Console.WriteLine("* Варинат #3                                                            *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с           *");
            Console.WriteLine("* клавиатуры и вычисляет находится ли точка с координатами              *");
            Console.WriteLine("* X,Y в заштрихованной области.                                         *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            int x, y;
            
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            
            
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));
            Console.ReadKey();
        }
    }
}
