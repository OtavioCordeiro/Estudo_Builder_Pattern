using Estudo_Builder_Patter_RealWorld.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Builder_Patter_RealWorld.Director
{
    public class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
