using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adapter - Match interfaces of different classes - 
            // Bridge - Separates an object’s interface from its implementation - 
            // Composite - A tree structure of simple and composite objects - 
            // Decorator - Add responsibilities to objects dynamically - 
            // Facade - A single class that represents an entire subsystem - 
            // Flyweight - A fine-grained instance used for efficient sharing - 
            // Proxy - An object representing another object - 

            Console.WriteLine($"1. Decorator (使用頻率：高)");

            Console.WriteLine();

            string number = "";
            // 重新輸入：空的或有其他字元
            while (string.IsNullOrEmpty(number) || Regex.IsMatch(number, @"[^\d]+"))
            {
                Console.WriteLine($"請輸入模式：");
                number = Console.ReadLine();
            }

            var intNumber = Convert.ToInt32(number);
            //var program = new Program();
            //switch (intNumber)
            //{
            //    case 1:
            //        program.SimpleFactory();
            //        break;
            //    case 2:
            //        program.FactoryMethod();
            //        break;
            //    case 3:
            //        program.AbstractFactory();
            //        break;
            //    case 4:
            //        program.Singleton();
            //        break;
            //}

            Console.ReadKey();
        }
    }
}
