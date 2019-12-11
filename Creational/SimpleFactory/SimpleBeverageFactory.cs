using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDojo.Creational.SimpleFactory
{
    public class SimpleBeverageFactory
    {
        public static IBeverageProvide CreateBeverage(string type)
        {
            IBeverageProvide beverageProvide = null;
            switch (type)
            {
                case "BlackTea":
                    beverageProvide = new BlackTea();
                    break;
                case "Coffee":
                    beverageProvide = new Coffee();
                    break;
            }

            return beverageProvide;
        }
    }
}
