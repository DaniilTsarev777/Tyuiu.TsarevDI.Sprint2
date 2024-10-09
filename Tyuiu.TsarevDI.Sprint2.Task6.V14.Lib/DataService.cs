using tyuiu.cources.programming.interfaces.Sprint2; 
namespace Tyuiu.TsarevDI.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            string res;
            k = (d + (k % 7) - 1) % 7;
            res = k switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье"
            };
            return res;


        }
    }
}
