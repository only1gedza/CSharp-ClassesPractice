using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDemo {

    public class Vehicle
    {
        public Vehicle(string vehicleType, string powerReqs)
        {
            VehicleType = vehicleType;
            PowerReqs = powerReqs;
        }

        public string VehicleType { get; set; };
        public string PowerReqs { get; set; };

    }

    public class Car : Vehicle
    {
        public Car(string carType, string engineType) : base(vehicleType, powerReqs)
        {
            CarType = carType;
            EngineType = engineType;
        }

        public string CarType { get; set; };
        public string EngineType { get; set; };
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle(string bikeType, string bikeEngine, string vehicleType,string powerReqs) : base(vehicleType, powerReqs)
        {
            BikeType = bikeType;
            BikeEngine = bikeEngine;
        }

        public string BikeType { get; set; };
        public string BikeEngine { get; set; };

        public const int bikeWheels = 2;
    }

}
