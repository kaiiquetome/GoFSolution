using ChainOfResponsibility.Handler;
using ChainOfResponsibility.Model;
using System;
namespace ChainOfResponsibility.ConcreteHandler
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                    this.GetType().Name, purchase.Number);
            }
            else if (successor != null)
            {
                successor.ProcessRequest(purchase);
            }
        }
    }
}
