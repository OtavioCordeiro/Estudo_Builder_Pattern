using Estudo_Builder_Patter_RealWorld.Builder;
using Estudo_Builder_Patter_RealWorld.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Builder_Patter_RealWorld.ConcreteBuilders
{
    public class ScooterBuilder : VehicleBuilder
    {
        public ScooterBuilder()
        {
            Vehicle = new Vehicle("Scooter");
        }
        public override void BuildFrame()
        {
            Vehicle["frame"] = "Scooter Frame";
        }
        public override void BuildEngine()
        {
            Vehicle["engine"] = "50 cc";
        }
        public override void BuildWheels()
        {
            Vehicle["wheels"] = "2";
        }
        public override void BuildDoors()
        {
            Vehicle["doors"] = "0";
        }
    }
}
