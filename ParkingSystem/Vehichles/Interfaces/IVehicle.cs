using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehichles.Interfaces
{
    public interface IVehicle
    {
        public int NoEconomicCar();
        public int GetWeight();
        public int GetWidth();
    }
}
