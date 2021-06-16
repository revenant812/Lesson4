using System;

namespace Lesson4Work3
{
    class Program
    {
        enum listMonth
        {
            Winter,
            Spring,
            Summer,
            Autumn,
        }
        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер текущего месяца: ");
            string NumberMonth = Console.ReadLine();
            int NumberMonthInt = Convert.ToInt32(NumberMonth);
            Console.WriteLine(FindMonth(NumberMonthInt));

        }

        static listMonth FindMonth(int i)
        {
            listMonth result;
            switch (i)
            {
                case 1:
                    result = listMonth.Winter;
                    break;
                case 2:
                    result = listMonth.Winter;
                    break;
                case 3:
                    result = listMonth.Spring;
                    break;
            }
            return result;
        }
    }
}
