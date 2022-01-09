using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23_1
{
    class Program
    {         
        static async Task<decimal> Factorial(int n)
        {
            return await Task.Run<decimal>(() =>
            {
                decimal result = 1;
                for (int i = 1; i <= n; i++) result *= i;
                return result;
            });
        }

        static void Main(string[] args)
        {
            
            Console.Write("Введите число, для которого будем считать факториал:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат: " + Factorial(n).Result);
            Console.ReadLine();
        }
    }
}
