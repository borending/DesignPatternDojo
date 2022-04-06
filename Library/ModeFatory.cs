using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Dojo
{
    public abstract class ModeFatory
    {
        public readonly static string Name;

        protected readonly ICollection<PatternProduct> _patterns;

        public void Execute()
        {
            if (_patterns == null || !_patterns.Any())
            {
                Console.WriteLine($"工廠尚未初始化，結束處理");
                return;
            }

            var counts = _patterns.Count();

            for (int index = 0; index <= counts; index++)
            {
                var pattern = _patterns.ElementAt(index);
                Console.WriteLine($"{index + 1:00}. {pattern.Name:-20} (使用頻率：{pattern.UsedFrequency:-15}");
            }

            Console.WriteLine();

            string number = "";
            // 重新輸入：空的或有其他字元
            while (string.IsNullOrEmpty(number) || Regex.IsMatch(number, @"[^\d]+"))
            {
                Console.WriteLine($"請輸入模式：");
                number = Console.ReadLine();
            }

            var intNumber = Convert.ToInt32(number);
            if(intNumber == 0 || intNumber > counts)
            {
                Console.WriteLine($"輸入不合法，結束處理");
                return;
            }

            var instance = _patterns.ElementAt(intNumber - 1);
            Console.WriteLine($"開始執行Pattern: {instance.Name} ...");
            instance.Execute();
        }
    }
}
