using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Creational.SimpleFactory
{
    public class Coffee : IBeverageProvide
    {
        public void AddMaterial()
        {
            Console.WriteLine("裝原料:加入咖啡粉");
        }

        public void Brew()
        {
            Console.WriteLine("烹煮:加入熱水");
            Console.WriteLine("烹煮:加入牛奶");
        }

        public void PouredCup()
        {
            Console.WriteLine("裝杯:加入冰塊");
            Console.WriteLine("裝杯:倒入馬克杯");
        }
    }
}
