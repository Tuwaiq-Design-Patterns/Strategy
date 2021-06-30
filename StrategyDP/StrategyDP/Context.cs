namespace StrategyDP
{
    public class Context
    {
        public IStrategy Strategy { get; set; }

        public void executeStrategy()
        {
            Strategy.execute();
        }
    }
}