using Tyuiu.TsarevDI.Sprint2.Task1.V22.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task1.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a, b, c, d;
            a = 324;
            b = 696;
            c = 254;
            d = 155;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема: Логические операции                                             *");
            Console.WriteLine("* Задание #1                                                            *");
            Console.WriteLine("* Варинат #22                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу из операций сравнений                              *");
            Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций можно чередовать   *");
            Console.WriteLine("* но использовать один раз в выражении) и и логических операций         *");
            Console.WriteLine("* (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться)*");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую           *");
            Console.WriteLine("* последовательность(массив): (True, True, True, False, False, False)   *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("A = "+a);
            Console.WriteLine("B = "+b);
            Console.WriteLine("C = "+c);
            Console.WriteLine("D = "+d);

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();



        }
    }
}
