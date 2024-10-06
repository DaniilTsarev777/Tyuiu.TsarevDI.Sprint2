using Tyuiu.TsarevDI.Sprint2.Task3.V14.Lib;
namespace Tyuiu.TsarevDI.Sprint2.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Царёв Д. И. | СМАРТб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #2                                                             *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                   *");
            Console.WriteLine("* Задание #3                                                            *");
            Console.WriteLine("* Варинат #14                                                           *");
            Console.WriteLine("* Выполнил: Царёв Даниил Ильич | СМАРТб-24-1                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y    *");
            Console.WriteLine("* с использованием вложенных оператор if-else, где пользователь вводит  *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение     *");
            Console.WriteLine("* до трех знаков после запятой;                                         *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            double x;
            Console.WriteLine("Введите Число: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            
            Console.WriteLine("Значение функции = "+ds.Calculate(x));
            Console.ReadKey();

        }
    }
}
