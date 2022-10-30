using ObserverPattern.Subject;

namespace ObserverPattern.ConcreteSubject
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    public class IBM : Stock
    {
        // Constructor
        public IBM(string symbol, double price)
            : base(symbol, price)
        {
        }
    }
}
