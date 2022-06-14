using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDemo
{

    public class Vehicle
    {
        public Vehicle(string vehicleClass, string powerReqs)
        {
            VehicleClass = vehicleClass;
            PowerReqs = powerReqs;
        }

        public string VehicleClass { get; set; };
        public string PowerReqs { get; set; };

    }

    public class Car : Vehicle
    {
        public Car(string carType, string engineType, int doors, string vehicleClass, string powerReqs) : base(vehicleClass, powerReqs)
        {
            CarType = carType;
            EngineType = engineType;
            NumberOfDoors = doors;
        }

        public string CarType { get; set; };
        public string EngineType { get; set; };
        int NumberOfDoors { get; set; };

        public const int carWheels = 4;
    }

    public class Bike : Vehicle
    {
        public Bike(string bikeType, string bikeEngine, string vehicleClass, string powerReqs) : base(vehicleClass, powerReqs)
        {
            BikeType = bikeType;
            BikeEngine = bikeEngine;
        }

        public string BikeType { get; set; };
        public string BikeEngine { get; set; };

        public const int bikeWheels = 2;
    }

    public class IndustrialVehicle : Vehicle
    {
        public IndustrialVehicle(string industryVehicleType, string machineType, string machinePowerSource, string vehicleClass, string powerReqs) : base(vehicleClass, powerReqs)
        {
            IndustryVehicleType = industryVehicleType;
            MachineType = machineType;
            MachinePowerSource = machinePowerSource;
        }

        public string IndustryVehicleType { get; set; };
        public string MachineType { get; set; };
        public string MachinePowerSource { get; set; };
    }

    public class CommercialVehicle : Vehicle
    {
        public CommercialVehicle(string commerceType, int numSeats, int wheels, string vehicleClass, string powerReqs) : base(vehicleClass, powerReqs)
        {
            CommerceType = commerceType;
            NumSeats = numSeats;
            Wheels = wheels;
        }

        public int NumSeats { get; set; };
        public int Wheels { get; set; };
        public string CommerceType { get; set; };
    }
}
