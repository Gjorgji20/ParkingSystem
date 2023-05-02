using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehichles
{
    public class Car : Vehicle
    {
        //
        public string TypeCar { get; set; }
        public Car() { }

        public Car(string carId, string model, int productionYear,
            Person owner, int weight, Fuel fuelType, int width, 
            int passengersNo, string typeCar) : 
            base(carId, model, productionYear, owner, weight, fuelType, width, passengersNo)
        {
            TypeCar = typeCar;
        }

        public override int NoEconomicCar()
        {
            return base.NoEconomicCar();
        }
    }
}
