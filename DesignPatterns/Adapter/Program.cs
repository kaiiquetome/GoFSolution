using Adapter.Adapter;
using Adapter.Target;
using System;

namespace Adapter
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound();
            unknown.Display();
            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();
            Compound benzene = new RichCompound("Benzene");
            benzene.Display();
            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
            // Wait for user
            Console.ReadKey();
        }
    }
}