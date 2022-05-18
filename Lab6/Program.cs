using System;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to find the Fibonacci Series for:");
            int k = Convert.ToInt32(Console.ReadLine());

            FibIteration fibIteration = new FibIteration();
            int fibResult = fibIteration.calculate_fib(k);
            Console.WriteLine("Fib of {0} by iteration is :{1} ", k, fibResult);

            FibFormula fibFormula = new FibFormula();
            int fibForm = fibFormula.calculate_fib(k);
            Console.WriteLine("Fib of {0} by formula is :{1} ", k, fibForm);
        }
    }
}
