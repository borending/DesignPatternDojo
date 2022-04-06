using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dojo
{
    class Program
    {
        // 未來有新增Mode，只要在集合中加上新Mode 名稱、修改switch 就可以
        private static ICollection<string> _modeNames = new List<string>
        {

        };

        static void Main(string[] args)
        {
            Console.WriteLine($"－－－－－－－－－－－－－－－－－");
            Console.WriteLine($"－－－歡迎來到設計模式訓練場－－－");
            Console.WriteLine($"－－－－－－－－－－－－－－－－－");
            Console.WriteLine();

            if (_modeNames == null || !_modeNames.Any())
            {
                Console.WriteLine($"尚未初始化，結束處理");
                Console.ReadLine();
                return;
            }

            var counts = _modeNames.Count();
            for (int index = 0; index <= counts; index++)
            {
                var name = _modeNames.ElementAt(index);
                Console.WriteLine($"{index + 1:00}. {name:-20}");
            }
            Console.WriteLine();

            string number = "";
            while (string.IsNullOrEmpty(number) || Regex.IsMatch(number, @"[^\d]+"))
            {
                Console.WriteLine($"請輸入模式：");
                number = Console.ReadLine();
            }

            var intNumber = Convert.ToInt32(number);
            if (intNumber == 0 || intNumber > counts)
            {
                Console.WriteLine($"輸入不合法，結束處理");
                Console.ReadLine();
                return;
            }

            ModeFatory instance = null;
            var selectedName = _modeNames.ElementAt(intNumber - 1);
            Console.WriteLine($"開始執行Pattern: {selectedName} ...");
            switch (selectedName)
            {
                case "":
                    // todo
                    break;
                default:
                    break;
            }

            if (instance != null)
                instance.Execute();

            Console.ReadLine();
        }
    }
}
