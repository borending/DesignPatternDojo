using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Creational.SimpleFactory
{
    public class BlackTea : IBeverageProvide
    {
        public void AddMaterial()
        {
            Console.WriteLine("裝原料:加入茶葉");
        }

        public void Brew()
        {
            Console.WriteLine("烹煮:加入熱水");
        }

        public void PouredCup()
        {
            Console.WriteLine("裝杯:加入冰塊");
            Console.WriteLine("裝杯:倒入玻璃杯");
        }
    }
}
