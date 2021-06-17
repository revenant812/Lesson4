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
            if((NumberMonthInt > 0)  && (NumberMonthInt < 13))
            {
                Console.WriteLine(NameTime(FindMonth(NumberMonthInt)));
            }
            else
            {
                Console.Write("Ошибка: введите число от 1 до 12");
            }         
        }

        static listMonth FindMonth(int i)
        {            
            switch((i % 12)/3)
            {
                case 0:
                    return listMonth.Winter;                   
                case 1:
                    return listMonth.Spring;                   
                case 2:
                    return listMonth.Summer;                   
                default:
                    return listMonth.Autumn;
            }

            /*  
                1 % 12 = 1 (0 * 12 + 1) /3 = 0
                2 % 12 = 2 (0 * 12 + 2) /3 = 0
                3 % 12 = 3 (0 * 12 + 3) /3 = 1
                4 % 12 = 4 (0 * 12 + 4) /3 = 1
                5 % 12 = 5 (0 * 12 + 5) /3 = 1
                6 % 12 = 6 (0 * 12 + 6) /3 = 2
                7 % 12 = 7 (0 * 12 + 7) /3 = 2
                8 % 12 = 8 (0 * 12 + 8) /3 = 2
                9 % 12 = 9 (0 * 12 + 9) /3 = 3
                10 % 12 = 10 (0 * 12 + 10) /3 = 3
                11 % 12 = 11 (0 * 12 + 11) /3 = 3
                12 % 12 = 12 (0 * 12 + 12) /3 = 0
            
            switch (i)
            {
                case 1:                    
                    return listMonth.Winter;
                case 2:
                    return listMonth.Winter;
                case 3:
                   return listMonth.Spring;
                case 4:
                    return listMonth.Spring;
                case 5:
                    return listMonth.Spring;
                case 6:
                    return listMonth.Summer;
                case 7:
                    return listMonth.Summer;
                case 8:
                    return listMonth.Summer;
                case 9:
                    return listMonth.Autumn;
                case 10:
                    return listMonth.Autumn;
                case 11:
                    return listMonth.Autumn;
                case 12:
                    return listMonth.Winter;
                default:
                    return listMonth.Winter;
            */
        }
        static string NameTime(listMonth x)
        {
            string a;
            switch(x)
            {
                case listMonth.Winter:
                    a = "Зима";
                    return a;                         
                case listMonth.Spring:
                    a = "Весна";
                    return a;                
                case listMonth.Summer:
                    a = "Лето";
                    return a;                  
                default:
                    a = "Осень";
                    return a;
            }
        }
    }
}
