using System;

namespace MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            int n;
            double sum = 1;
            Console.WriteLine("Enter x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter n:");
            n = int.Parse(Console.ReadLine());
            if(n == 0)
            {
                Console.WriteLine("Result is 1");
            }
            else if(n > 0)
            {
                for(int i = 1; i <= n; i++)
                {
                    sum *= x;
                }
                Console.WriteLine("Result is {0}",sum);
            }
            else
            {
                for (int i = 1; i <= Math.Abs(n); i++)
                {
                    sum *= x;
                }
                Console.WriteLine("Result is {0}", 1/sum);

            }
        }
    }
}
