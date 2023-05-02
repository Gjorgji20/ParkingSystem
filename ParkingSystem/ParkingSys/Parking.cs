using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingSystem.Vehichles;

namespace ParkingSystem.ParkingSys
{
    public class Parking
    {
        public int ParkingId { get; set; }
        public static int ParkingSpaceNumber { get; set; } = 0;
        public string Address { get; set; }
        public string City { get; set; }
        public int PricePerHour { get; set; }
        public int Discount { get; set; }

        public Day FreeDays { get; set; }

        public Company OwnerCompany { get; set; }

        public List<VehicleInfo> vehicles { get; set; } = new List<VehicleInfo>();


        public Parking() { }

        public Parking(int parkingId, int parkingSpaceNumber, string address, string city, int pricePerHour, int discount, Day freeDays, Company ownerCompany)
        {
            ParkingId = parkingId;
            ParkingSpaceNumber = parkingSpaceNumber;
            Address = address;
            City = city;
            PricePerHour = pricePerHour;
            Discount = discount;
            FreeDays = freeDays;
            OwnerCompany = ownerCompany;
        }

        public string addVehicle(Vehicle vehicle, int TimeOfParking)
        {
            if (ParkingSpaceNumber < 100)
            {

                if (vehicle is Car)
                {
                    vehicles.Add(new VehicleInfo(vehicle, TimeOfParking, true, false, false));
                    ParkingSpaceNumber++;
                    return "Success added car";
                }
                else if (vehicle is Lorry)
                {
                    vehicles.Add(new VehicleInfo(vehicle, TimeOfParking, false, false, true));
                    ParkingSpaceNumber++;
                    return "Success added lorry";

                }
                else
                {
                    vehicles.Add(new VehicleInfo(vehicle, TimeOfParking, false, true, false));
                    ParkingSpaceNumber++;
                    return "Success added bus";
                }


            }
            else
            {
                return "The parking is full";
            }
        }
        public string removeVehicle(string VehicleId)
        {
            var TotalAmount = 0;

            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Vehicle.CarId.Equals(VehicleId))
                {
                    if (!FreeDays.Equals(DateTime.Now.DayOfYear))
                    {
                        TotalAmount = PricePerHour * vehicles[i].TimeParking;
                        vehicles.Remove(vehicles[i]);
                        ParkingSpaceNumber--;
                    }else
                    {
                        
                        vehicles.Remove(vehicles[i]);
                        ParkingSpaceNumber--;
                    }
                }

            }


            return $"Total amount is {TotalAmount.ToString()}";

        }

        public Vehicle serachVehicleById(string VehicleId)
        {
            var vehicle = new Vehicle();
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Vehicle.CarId.Equals(VehicleId))
                    vehicle = vehicles[i].Vehicle;
            }
            return vehicle;
        }
        public string totalVehicleInParking(string typeVehicle)
        {
            int counter = 0;
            if (typeVehicle.ToLower().Equals("car"))
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].IsCar)
                    {
                        counter++;
                    }
                }
            }
            else if (typeVehicle.ToLower().Equals("bus"))
            {

                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].IsBus)
                    {
                        counter++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].IsLorry)
                    {
                        counter++;
                    }
                }
            }

            return $"Total number of {typeVehicle} is: {counter.ToString()}";
        }

        public string getTimeOfParking(string carId)
        {
            string message = "";
            for (int i = 0; i < vehicles.Count; i++)
            {
                if (vehicles[i].Vehicle.CarId.Equals(carId))
                {
                    message = $"Your parking time is: {vehicles[i].TimeParking}";
                }
                else
                {
                    message = "This vehicle is not at this parking";
                }
            }
            return message;
        }
        public string getTotalAmount(string vehicleId)
        {
            var TotalAmount = 0;
            if (!FreeDays.Equals(DateTime.Now.DayOfWeek))
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (vehicles[i].Vehicle.CarId.Equals(vehicleId))
                    {

                        TotalAmount = PricePerHour * vehicles[i].TimeParking;

                    }

                }
            return $"Total amount is: {TotalAmount}";
            }else
            {
                return "The parking is free today";
            }
        }

        public string getFreeSpaces()
        {
            return $"This parking has just {ParkingSpaceNumber} spaces free";
        }

    }
}
