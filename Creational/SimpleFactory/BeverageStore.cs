using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Creational.SimpleFactory
{
    public class BeverageStore
    {
        public IBeverageProvide BeverageOrders(string type)
        {
            var beverage = SimpleBeverageFactory.CreateBeverage(type);
            beverage.AddMaterial();
            beverage.Brew();
            beverage.PouredCup();

            return beverage;
        }
    }
}
