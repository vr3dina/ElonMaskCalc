using System;
using System.Linq;

namespace EM.Calc.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] opers = { "pow", "sum", "sub", "mul", "new" };
            string operation;
            int[] values = new int[1];
            var calc = new Core.Calc();

            if (args.Length == 0)
            {
                Console.WriteLine("Aviable operations: ");
                foreach (var item in opers)
                {
                    Console.WriteLine("{0} ", item);
                }
                Console.WriteLine("Enter operation: ");
                operation = Console.ReadLine();

                Console.WriteLine("Enter operands: ");
                var operands = Console.ReadLine();
                values = operands.Split(new[] { " ", ";"}, StringSplitOptions.RemoveEmptyEntries).Select((n) => Convert.ToInt32(n)).ToArray();
            }
            else
            {
                operation = args[0].ToLower();
                values = args.Select((n) => Convert.ToInt32(n)).ToArray();              
            }

            int res = calc.Calculate(operation, values);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}