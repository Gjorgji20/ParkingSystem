using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehichles
{
    public class Bus : Vehicle
    {
        public bool Toalet { get; set; }
        public Bus() { }
        public Bus(string carId, string model, int productionYear, Person owner, int weight,
            Fuel fuelType, int width, int passengersNo, bool toalet)
            : base(carId, model, productionYear, owner, weight, fuelType, width, passengersNo)
        {
            Toalet = toalet;
        }
        public override int NoEconomicCar()
        {
            return base.NoEconomicCar();
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
