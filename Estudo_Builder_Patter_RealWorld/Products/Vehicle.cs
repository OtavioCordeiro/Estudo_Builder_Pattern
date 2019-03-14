using System;
using System.Collections.Generic;
using System.Text;

namespace Estudo_Builder_Patter_RealWorld.Products
{
    public class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine($"Vehicle type: {_vehicleType}");
            Console.WriteLine($" Frame : {_parts["frame"]}");
            Console.WriteLine($" Engine : {_parts["engine"]}");
            Console.WriteLine($" #Wheels : {_parts["wheels"]}");
            Console.WriteLine($" #Doors : {_parts["doors"]}");
        }
    }
}
