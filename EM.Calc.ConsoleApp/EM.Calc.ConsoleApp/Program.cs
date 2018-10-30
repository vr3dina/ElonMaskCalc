using System;
using System.Linq;

namespace EM.Calc.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation, operands;
            Console.WriteLine("Enter operation: ");
            operation = Console.ReadLine();

            Console.WriteLine("Enter operands: ");
            operands = Console.ReadLine();

            Core.Calc calc = new Core.Calc();
            int res = calc.Calculate(operation, operands.Split(' ').Select((n) => Convert.ToInt32(n)).ToArray());
            Console.WriteLine("{0} {1} = {2}", operation, operands, res);
            Console.ReadKey();
        }
    }
}