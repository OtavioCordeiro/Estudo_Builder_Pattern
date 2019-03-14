using Estudo_Builder_Patter_RealWorld.Builder;
using Estudo_Builder_Patter_RealWorld.ConcreteBuilders;
using Estudo_Builder_Patter_RealWorld.Director;
using System;

namespace Estudo_Builder_Patter_RealWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder;

            Shop shop = new Shop();

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }
    }
}
