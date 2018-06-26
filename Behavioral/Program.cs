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

        public static void Strategy()
        {
            Console.WriteLine("弓箭手使出攻擊!!");
            var archer = new Archer();
            int damage = archer.PerformAttack(new AttackWithArrow());
            Console.WriteLine($"造成 {damage.ToString()} 點傷害。");
        }
    }
}
