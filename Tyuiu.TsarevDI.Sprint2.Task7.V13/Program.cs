using Tyuiu.TsarevDI.Sprint2.Task7.V13.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема: обавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                            *");
            Console.WriteLine("* Варинат #13                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.CheckDotInShadedArea(x, y));

        }
    }
}
