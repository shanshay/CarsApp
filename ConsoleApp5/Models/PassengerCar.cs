using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    public class PassengerCar : Car
    {
        public int CountOfPassengers { get; set; }

        public PassengerCar (
            int speedKmPerHour, 
            double averageFuel, 
            double fuelTankVolume, 
            int overPercent, 
            int countOfPassengers)
            : base(
                  speedKmPerHour, 
                  averageFuel, 
                  fuelTankVolume,                   
                  overPercent)
        {
            this.Type = VehicleTypeEnum.PassengerCar;
            this.CountOfPassengers = countOfPassengers;
        }

        public override void GetInfoAboutTheRangeDependingOnCargo(
            int checkParam,
            double countOfLiters,
            ref double powerReserve)
        {
            var distance = this.HowManyKilometersCanTravel(countOfLiters);
            var overPercent = checkParam > this.CountOfPassengers ? (checkParam - this.CountOfPassengers) * this.OverPercent : 0;            
            powerReserve = distance + ((distance / 100) * overPercent);
        }
    }
}
