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
            SimpleFactory();

            Console.ReadKey();
        }

        // SimpleFactory 簡單工廠模式
        // 透過同一個方法傳入不同參數，獲得不同的衍生類別
        // reference : https://dotblogs.com.tw/joysdw12/2013/06/23/design-pattern-simple-factory-pattern
        public static void SimpleFactory()
        {
            // 告訴工廠要做飲料 BlackTea，得到BlackTea 的衍生類別
            var beverage = SimpleBeverageFactory.CreateBeverage("BlackTea");
            // 裝原料
            beverage.AddMaterial(); 
            // 烹煮
            beverage.Brew();
            // 裝杯
            beverage.PouredCup();

        }
    }
}
