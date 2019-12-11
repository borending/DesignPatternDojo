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
        public static void SimpleFactory()
        {

        }
    }
}
