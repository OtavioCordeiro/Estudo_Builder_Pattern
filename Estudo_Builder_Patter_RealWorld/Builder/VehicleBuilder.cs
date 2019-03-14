using Estudo_Builder_Patter_RealWorld.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Builder_Patter_RealWorld.Builder
{
    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; set; }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
