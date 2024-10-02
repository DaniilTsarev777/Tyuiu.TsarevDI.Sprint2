using Tyuiu.TsarevDI.Sprint2.Task0.V20.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task0.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x, y;
            x = 1075;
            y = 275;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.Title = "Спринт #1 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема: Операции сравнения                                              *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Варинат #11                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу из операций сравнений                              *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна          *");
            Console.WriteLine("* нарушаться) и арифметических выражений, которая вернет                *");
            Console.WriteLine("* логическую последовательность(массив):(True,False,True,False,True,    *");
            Console.WriteLine("* False), при x = 1075, y = 275                                         *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);



            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
                Console.ReadKey();
            }


        }
    }
}
