using System;

namespace GitBashLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите желаемую сумму: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double res = 0;
            if (a < 100)
            {
                res = a + (a * 0.05);
            }
            else if (a < 200)
            {
                res = a + (a * 0.07);
            }
            else if (a >= 200)
            {
                res = a + (a * 0.1);
            }
            Console.WriteLine($"Итоговая сумма: {res}");
        }
    }
}
