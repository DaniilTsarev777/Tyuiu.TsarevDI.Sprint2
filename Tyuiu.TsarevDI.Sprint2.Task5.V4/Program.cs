using Tyuiu.TsarevDI.Sprint2.Task5.V4.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
           

            Console.Title = "Спринт #2 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема: Оператор switch                                                 *");
            Console.WriteLine("* Задание #5                                                            *");
            Console.WriteLine("* Варинат #4                                                            *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая использует оператор switch                *");
            Console.WriteLine("* вычисляет требуемое значение и возвращает результат.                  *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Введите номер масти: ");
            int x = Convert.ToInt32(Console.ReadLine());
            



            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            string res;
            res = "";
            if ((x < 1) || (x > 4))
            {
                Console.WriteLine("Введен неправильный номер!");
            }
            else
            {
                res = "Этому номеру соответсвует " + ds.FindCardSuit(x);
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
