using DesignPatternDojo.Creational.Factory;
using DesignPatternDojo.Creational.SimpleFactory;
using DesignPatternDojo.Creational.Singleton;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace DesignPatternDojo.Creational
{
    class Program
    {
        static void Main(string[] args)
        {
            // Builder - Separates object construction from its representation - 中低
            // Prototype - A fully initialized instance to be copied or cloned - 中

            Console.WriteLine($"1. SimpleFactory (使用頻率：高)");
            Console.WriteLine($"2. FactoryMethod (使用頻率：高)");
            Console.WriteLine($"3. Abstract Factory (使用頻率：高)");
            Console.WriteLine($"4. Singleton (使用頻率：中高)");

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
                    program.SimpleFactory();
                    break;
                case 2:
                    program.FactoryMethod();
                    break;
                case 3:
                    program.AbstractFactory();
                    break;
                case 4:
                    program.Singleton();
                    break;
            }

            Console.ReadKey();
        }

        public void SimpleFactory()
        {
            // SimpleFactory 簡單工廠模式
            // 應用場景：只用一個Factory，就可以產生不同實體的產品ConcreteProduct
            // reference : https://skyyen999.gitbooks.io/-study-design-pattern-in-java/content/simpleFactory.html

            // 有多個產品Product，所以把Product 抽象化，透過傳入不同參數，實體化各種"實作抽象介面Product 的ConcreteProduct"

            // 告訴工廠要做飲料 BlackTea，得到BlackTea 的衍生類別
            var beverage = SimpleBeverageFactory.CreateBeverage("BlackTea");
            // 裝原料
            beverage.AddMaterial();
            // 烹煮
            beverage.Brew();
            // 裝杯
            beverage.PouredCup();
        }

        public void FactoryMethod()
        {
            // Factory Method 工廠模式
            // 應用場景：用不同的工廠ConcreteFactory，產生不同實體的產品ConcreteProduct
            // reference :
            // https://skyyen999.gitbooks.io/-study-design-pattern-in-java/content/factory.html
            // https://www.dofactory.com/net/factory-method-design-pattern

            // 定義一個工廠物件作為介面，透過不同的子類別實作
            // 先定義抽象的Creator 跟Product，規範屬性及方法
            // 再各自定義具體的Creator 跟Product實作

            // 文件有很多種，假設目前有兩種：履歷 以及 報告 為具體Creator
            var documents = new List<Document> { new Resume(), new Report() };
            foreach (var document in documents)
            {
                Console.WriteLine($"{document.GetType().Name}--");
                foreach (var page in document.Pages)
                    Console.WriteLine($"{page.GetType().Name}");
            }
        }

        public void AbstractFactory()
        {
            // Abstract Factory 抽象工廠模式
            // 應用場景：不同的工廠ConcreteFactory，產生多種Product 的實體化的產品ConcreteProduct
            // reference : https://skyyen999.gitbooks.io/-study-design-pattern-in-java/content/abstractFactory1.html

            // todo
        }

        public void Singleton()
        {
            // Singleton 單例模式
            // 應用場景：只創造一個實體，且同時只能有一個實體存在
            // reference : 
            // https://www.dofactory.com/net/singleton-design-pattern
            // https://ithelp.ithome.com.tw/articles/10230064

            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();
            if (b1 == b2 && b2 == b3 && b3 == b4)
                Console.WriteLine("實體相同");

            // 模擬15 個Request ，分別連線到的哪一個Server
            var balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                var server = balancer.NextServer;
                Console.WriteLine($"Request {i + 1:00} 連線至IP: {server.IP:-16} - {server.Name:-9}");
            }

            // thread-safe issue
            // https://ithelp.ithome.com.tw/articles/10196899
            // https://riptutorial.com/design-patterns/example/21713/csharp-example--multithreaded-singleton
        }
    }
}
