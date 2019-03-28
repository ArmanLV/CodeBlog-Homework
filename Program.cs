using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());

            int MaxInt = 0;
            int Parity = 0;

            MaxInt = Math.Max(input1, input2);

            if (input3 > MaxInt)
            {
                MaxInt = input3;
            }

            Console.WriteLine("Максимальное число: " + MaxInt);

            Parity = MaxInt % 2;

            switch (Parity)
            {
                case 0:
                    Console.WriteLine("Число: " + MaxInt + " Чётное");
                    break;
                default:
                    Console.WriteLine("Число: " + MaxInt + " Нечётное");
                    break;
            }

            Console.WriteLine(MaxInt > 100 ? "Число: " + MaxInt + " больше 100" : "Число: " + MaxInt + " меньше 100");
            Console.ReadLine();
        }
    }
}