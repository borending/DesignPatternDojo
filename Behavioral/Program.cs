using DesignPatternDojo.Behavioral.Observer;
using DesignPatternDojo.Behavioral.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatternDojo.Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chain of Resp - A way of passing a request between a chain of objects
            // Command - Encapsulate a command request as an object
            // Interpreter - A way to include language elements in a program
            // Iterator - Sequentially access the elements of a collection
            // Mediator - Defines simplified communication between classes
            // Memento - Capture and restore an object's internal state
            // State - Alter an object's behavior when its state changes
            // Template Method - Defer the exact steps of an algorithm to a subclass
            // Visitor - Defines a new operation to a class without change

            Console.WriteLine($"1. Strategy (使用頻率：高)");
            Console.WriteLine($"2. Observer (使用頻率：高)");
            Console.WriteLine();

            string number = "";
            // 重新輸入：空的或有其他字元
            while (string.IsNullOrEmpty(number) || Regex.IsMatch(number, @"[^\d]+"))
            {
                Console.WriteLine($"請輸入模式：");
                number = Console.ReadLine();
            }

            var intNumber = Convert.ToInt32(number);
            var program = new Program();
            switch (intNumber)
            {
                case 1:
                    program.Strategy();
                    break;
                case 2:
                    program.Observer();
                    break;
            }

            Console.ReadKey();
        }


        public void Strategy()
        {
            // Strategy 策略模式 
            // 應用場景：一個事情(Method)用一些固定的邏輯(介面)、演算法，取得一個結果，依據狀況 切換不同的處理方法(類別實作介面方法)
            // reference : https://www.dofactory.com/net/strategy-design-pattern

            // 策略模式可以說是：一個類別(Context)使用一種行為(Action)，而這個行為會有不同種的動作(ConcreteAction)，
            // 在不同的場景，這個類別可以依據情況對於自己的同一個行為(Action)，選用不同的動作(ConcreteAction)。

            // 例如：有一個弓箭手(Context)使用攻擊這種行為(Action)，而攻擊行為會有不同種的動作(ConcreteAction)，
            // 有 使用弓箭射擊(ConcreteAction)、使用弓打擊(ConcreteAction)、使用腳踢擊(ConcreteAction)
            // 在不同的場景，這個弓箭手(Context)可以依據情況對攻擊這個行為(Action)，選用不同的動作(ConcreteAction)。
            Console.WriteLine("弓箭手使出攻擊!!");
            var archer = new Archer();
            Console.WriteLine($"造成 {archer.PerformAttack(new AttackWithArrow()).ToString()} 點傷害。");
        }

        public void Observer()
        {
            // Observer 觀察者模式 
            // 應用場景：當一個Subject(主題) 發生變動，觸發其Observer(s)(觀察者) 的事件
            // reference : https://www.dofactory.com/net/strategy-design-pattern

            var stock = new IBM("IBM", 120.00); // IBM 股票的價位為120
            stock.Attach(new Investor("Sorros"));   // 兩位投資者：Sorros, Berkshire 追蹤了這個IBM 股票
            stock.Attach(new Investor("Berkshire"));
            // 市場上的價位不斷變動，同時也會通知兩位投資者
            stock.Price = 120.10;
            stock.Price = 121.00;
            stock.Price = 120.50;
            stock.Price = 120.75;

            Console.ReadLine();
        }
    }
}
