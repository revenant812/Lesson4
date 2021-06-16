using System;

namespace Lesson4Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Наберите набор чисел через пробел:");
            string str = Console.ReadLine();
            Console.WriteLine(Foo(str));                     
        }
        
        static int Foo(string StrInt)
        {
            int result = 0;
            string[] array = StrInt.Split(' ');
            int[] ArrayInt = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                ArrayInt[i] = Convert.ToInt32(array[i]);
                //Console.WriteLine(ArrayInt[i]);
            }
           
            foreach(int x in ArrayInt)
            {
                result = result + x; 
            }

            return result;
        }
    }
}
