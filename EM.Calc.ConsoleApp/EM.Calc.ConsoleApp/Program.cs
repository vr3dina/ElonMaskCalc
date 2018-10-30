using System;
using System.Linq;

namespace EM.Calc.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Core.Calc();
            string[] opers = calc.Operations
                .Select(op => op.Name)
                .ToArray();
            string operation;
            double[] values;

            if (args.Length == 0)
            {
                Console.WriteLine("Aviable operations: ");
                foreach (var item in opers)
                {
                    Console.WriteLine("{0}", item);
                }

                Console.WriteLine("Enter operation: ");
                operation = Console.ReadLine();

                Console.WriteLine("Enter operands: ");
                var operands = Console.ReadLine();
                values = operands
                    .Split(new[] { " ", ";" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(Convert.ToDouble).ToArray();
            }
            else
            {
                operation = args[0].ToLower();
                values = args
                    .Skip(1)
                    .Select(Convert.ToDouble)
                    .ToArray();
            }

            double? res = calc.Calculate(operation, values);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}