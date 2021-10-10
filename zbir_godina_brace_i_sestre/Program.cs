using System;

namespace zbir_godina_brace_i_sestre
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, raz;

            a = int.Parse(Console.ReadLine());

            raz = a - 3;

            if ((raz % 4)> 0)
            {
                Console.WriteLine("ne");
            }
            else
            {
                Console.WriteLine("da");
            }
        }
    }
}
