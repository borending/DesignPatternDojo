namespace Dojo
{
    public enum UsedFrequency : int
    {
        Low,

        MediumLow,

        Medium,

        MediumHigh,

        High
    }

    public abstract class PatternProduct
    {
        public string Name { get; set; }

        public UsedFrequency UsedFrequency { get; set; }

        public abstract void Execute();
    }
}
