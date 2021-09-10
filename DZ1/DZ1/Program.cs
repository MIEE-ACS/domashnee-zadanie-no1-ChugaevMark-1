using System;

namespace DZ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число К: ");
            int k;
            while (true) {
                k = int.Parse(Console.ReadLine());
                if (k > 365 || k < 1)
                    Console.WriteLine("Введите число от 1 до 365 ");
                else
                    break;
            }
            int o = k % 7;
            Console.WriteLine($"Номер дня недели {o}");
        }
    }
}
