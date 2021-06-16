using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name1, string name2, string name3)[] array = CreateUsers();

            for(int i = 0; i < array.Length; i++)
            {
                PrintUsers(array[i]);
            }
            

        }

        static string GetFullName(string FirstName, string lastName, string Patronymic)
        {
            return $"{FirstName} {lastName} {Patronymic}";                          
        }

        static (string name1, string name2, string name3) GetUserName()
        {
            Console.Write("Ваша фамилия: ");
            string name1 = Console.ReadLine();
            Console.Write("Ваше имя: ");
            string name2 = Console.ReadLine();
            Console.Write("Ваше отчество: ");
            string name3 = Console.ReadLine();
            return (name1, name2, name3);
        }

        static (string username1, string username2, string username3) [] CreateUsers()
        {
            Console.Write("Введите количество пользователей: ");
            int count = Convert.ToInt32(Console.ReadLine());
            (string username1, string username2, string username3)[] array = new (string username1, string username2, string username3)[count];
            for(int i = 0; i < count; i++)
            {
              array[i] = GetUserName();
            }            
            return array;
        }

        static void PrintUsers((string name1, string name2, string name3) array)
        {
            Console.WriteLine($"{array.name1} {array.name2} {array.name3}");
        }

    }

       
}
