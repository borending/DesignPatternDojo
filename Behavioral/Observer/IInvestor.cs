namespace DesignPatternDojo.Behavioral.Observer
{
    /// <summary>
    /// 觀察者 介面
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
