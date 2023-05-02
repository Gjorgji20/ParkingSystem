using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.ParkingSys
{
    public class ParkingSys
    {
        public List<Parking> Parkings { get; set; } = new List<Parking>();

        public ParkingSys() { }

        public ParkingSys(List<Parking> parkings)
        {
            Parkings = parkings;
        }

        public bool findParking(int id)
        {
            bool flag = false;
            for(int i=0;i<Parkings.Count;i++)
            {
                if (Parkings[i].ParkingId==id)
                {
                    flag= true;
                }
            }
            return flag;
        }

        public Parking getParkingById(int id)
        {
            Parking parking=new Parking();
            for (int i = 0; i < Parkings.Count; i++)
            {
                if (Parkings[i].ParkingId == id)
                {
                    parking = Parkings[i];
                }
            }
            return parking;
        }
    }
}
