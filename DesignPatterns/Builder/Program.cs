using Builder.Builder;
using Builder.ConcreteBuilder;
using Builder.Director;
using System;

namespace Builder
{
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Main()
        {
            VehicleBuilder builder;
            // Create shop with vehicle builders
            Shop shop = new Shop();
            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            // Wait for user
            Console.ReadKey();
        }
    }
}
