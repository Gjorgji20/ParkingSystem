using ParkingSystem.Vehichles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehichles
{
    public class Vehicle : IVehicle
    {
        private string _cardId;
        public string CarId {
            get
            {
                return _cardId;
            }
            set
            {
                if (value != "5")
                {
                    _cardId = value;
                }else
                {
                    _cardId = "10";
                }
            }

         }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public Person Owner { get; set; }
        public int Weight { get; set; }
        public int Width { get; set; }
        public Fuel FuelType { get; set; }
        public int PassengersNo { get; set; }
        public Vehicle()
        { }
        public Vehicle(string carId, string model, int productionYear, Person owner, int weight, Fuel fuelType, int width, int passengersNo)
        {
            CarId = carId;
            Model = model;
            ProductionYear = productionYear;
            Owner = owner;
            Weight = weight;
            FuelType = fuelType;
            Width = width;
            PassengersNo = passengersNo;
        }
        public Vehicle(string carId)
        {
            CarId = carId;
        }
        public virtual int NoEconomicCar()
        {
            if (FuelType == Fuel.electricty)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int GetWeight()
        {
            return Weight;
        }
        public int GetWidth()
        {
            return Width;
        }
    }
}
