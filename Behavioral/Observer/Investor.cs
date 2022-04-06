using System;

namespace DesignPatternDojo.Behavioral.Observer
{
    /// <summary>
    /// 觀察者 實例
    /// </summary>
    public class Investor : IInvestor
    {
        private string _name;

        public Investor(string name)
        {
            this._name = name;
        }

        public void Update(Stock stock)
        {
            // 不同觀察者，在觀察對象更新時，實作各自的行為
            Console.WriteLine($"提醒： {_name} 您好，{stock.Symbol} 價位達到 {stock.Price:C}");
        }
    }
}
