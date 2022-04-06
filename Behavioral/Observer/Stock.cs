using System;
using System.Collections.Generic;

namespace DesignPatternDojo.Behavioral.Observer
{
    public abstract class Stock
    {
        public readonly string Symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();

        public double Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    Notify();
                }
            }
        }

        public Stock(string symbol, double price)
        {
            this.Symbol = symbol;
            this.price = price;
        }

        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            // 當Subject 改變時，通知觀察者們
            foreach (IInvestor investor in investors)
                investor.Update(this);
            Console.WriteLine();
        }
    }
}
