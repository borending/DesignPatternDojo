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
            throw new NotImplementedException();
        }

        public void Brew()
        {
            throw new NotImplementedException();
        }

        public void PouredCup()
        {
            throw new NotImplementedException();
        }
    }
}
