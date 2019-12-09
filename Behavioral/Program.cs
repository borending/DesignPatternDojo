using DesignPatternDojo.Behavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            Strategy();

            Console.ReadKey();
        }

        // Strategy Pattern 策略模式
        // 策略模式可以說是：一個類別(Context)使用一種行為(Action)，而這個行為會有不同種的動作(ConcreteAction)，
        // 在不同的場景，這個類別可以依據情況對於自己的同一個行為(Action)，選用不同的動作(ConcreteAction)。
        // 
        // 例如：有一個弓箭手(Context)使用攻擊這種行為(Action)，而攻擊行為會有不同種的動作(ConcreteAction)，
        // 有 使用弓箭射擊(ConcreteAction)、使用弓打擊(ConcreteAction)、使用腳踢擊(ConcreteAction)
        // 在不同的場景，這個弓箭手(Context)可以依據情況對攻擊這個行為(Action)，選用不同的動作(ConcreteAction)。
        public static void Strategy()
        {
            Console.WriteLine("弓箭手使出攻擊!!");
            var archer = new Archer();
            Console.WriteLine($"造成 {archer.PerformAttack(new AttackWithArrow()).ToString()} 點傷害。");
        }
    }
}
