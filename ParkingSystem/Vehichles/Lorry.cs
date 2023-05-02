using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehichles
{
    public class Lorry : Vehicle
    {
        public int Capacity { get; set; }
        public Lorry() { }
        public Lorry(string carId, string model, 
            int productionYear, Person owner, int weight, Fuel fuelType, int width, 
            int passengersNo, int capacity) : 
            base(carId, model, productionYear, owner, weight, fuelType, width, passengersNo)
        {
            Capacity = capacity;
        }
        public override int NoEconomicCar()
        {
            return base.NoEconomicCar();
        }

    }
}
