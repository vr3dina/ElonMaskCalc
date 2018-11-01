using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EM.Calc.Core
{
    public class Calc
    {
        public List<IOperation> Operations { get; set; }

        public Calc()
        {
            Operations = new List<IOperation>();

            string DLLsDirecoryPath = Directory.GetCurrentDirectory();
            FileInfo[] DLLFilePath = new DirectoryInfo(DLLsDirecoryPath).GetFiles("*.dll");

            foreach (var dll in DLLFilePath)
            {
                //Get assemly from file
                Assembly assembly = Assembly.LoadFile(dll.FullName);
                AddOperation(assembly);
            }
        }

        /// <summary>
        /// Add instances of clasees, 
        /// which implement IOperation interface
        /// to list of operations
        /// </summary>
        /// <param name="assembly"></param>
        private void AddOperation(Assembly assembly)
        {
            //Download all types from assembly
            Type[] types = assembly.GetTypes();

            var needType = typeof(IOperation);

            foreach (var type in types.Where(t => t.IsClass && !t.IsAbstract))
            {
                var interfaces = type.GetInterfaces();
                //if class implements the interface
                if (interfaces.Contains(needType))
                {
                    //add the class instance to operations list
                    var instance = Activator.CreateInstance(type);
                    if (instance is IOperation operation)
                    {
                        Operations.Add(operation);
                    }
                }
            }
        }

        public double? Calculate(string op, double[] args)
        {
            foreach (var operation in Operations)
            {
                if (operation.Name == op)
                {
                    operation.Operands = args;
                    return operation.Execute();
                }
            }
            return null;
        }

        #region old
        [Obsolete("Don't use it, use Calculate instead")]
        public double? Mult(double[] args)
        {
            MultOperation multOperation = new MultOperation
            {
                Operands = args
            };
            return multOperation.Execute();
        }

        [Obsolete("Don't use it, use Calculate instead")]
        public double? Pow(double[] args)
        {
            PowOperation powOperation = new PowOperation
            {
                Operands = args
            };
            return powOperation.Execute();
        }

        [Obsolete("Don't use it! Use Calculate instead")]
        public double? Sum(double[] args)
        {
            SumOperation sumOperation = new SumOperation
            {
                Operands = args
            };
            return sumOperation.Execute();
        }

        [Obsolete("Don't use it! Use Calculate instead")]
        public double? Sub(double[] args)
        {
            SubOperation subOperation = new SubOperation
            {
                Operands = args
            };
            return subOperation.Execute();
        }

        [Obsolete("Don't use it! Use Calculate instead")]
        public double? New(double[] args)
        {
            NewOperation newOperation = new NewOperation
            {
                Operands = args
            };
            return newOperation.Execute();
        }
        #endregion
    }
}
