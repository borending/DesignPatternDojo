using DesignPatternDojo.Creational.Factory;
using DesignPatternDojo.Creational.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Creational
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract Factory - Creates an instance of several families of classes
            // Builder - Separates object construction from its representation
            // Factory Method - Creates an instance of several derived classes
            // Prototype - A fully initialized instance to be copied or cloned
            // Singleton - A class of which only a single instance can exist


            //SimpleFactory();
            FactoryMethod();
            Console.ReadKey();
        }


        public static void SimpleFactory()
        {
            // SimpleFactory 簡單工廠模式
            // 只有一個具體的Factory，透過傳入不同參數，實體化各種"實作抽象介面Product 的ConcreteProduct"
            // reference : https://dotblogs.com.tw/joysdw12/2013/06/23/design-pattern-simple-factory-pattern

            // 告訴工廠要做飲料 BlackTea，得到BlackTea 的衍生類別
            var beverage = SimpleBeverageFactory.CreateBeverage("BlackTea");
            // 裝原料
            beverage.AddMaterial();
            // 烹煮
            beverage.Brew();
            // 裝杯
            beverage.PouredCup();
        }

        public static void FactoryMethod()
        {
            // Factory Method 工廠模式
            // 定義一個工廠物件作為介面，透過不同的子類別實作

            // 先定義抽象的Creator 跟Product，規範屬性及方法
            // 再各自定義具體的Creator 跟Product實作

            // 文件有很多種，假設目前有兩種：履歷 以及 報告 為具體Creator
            var documents = new List<Document> { new Resume(), new Report() };

            foreach(var document in documents)
            {
                Console.WriteLine($"{document.GetType().Name}--");
                foreach(var page in document.Pages)
                    Console.WriteLine($"{page.GetType().Name}");
            }
        }
    }
}
