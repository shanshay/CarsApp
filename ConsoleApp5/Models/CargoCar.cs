using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    public class CargoCar :Car
    {
        public int WeightCargo { get; set; }

        public CargoCar(
            int speedKmPerHour, 
            double averageFuel, 
            double fuelTankVolume,            
            int overPercent, 
            int weight)
            : base(
                  speedKmPerHour, 
                  averageFuel, 
                  fuelTankVolume,                  
                  overPercent)
        {
            this.Type = VehicleTypeEnum.CargoCar;
            this.WeightCargo = weight;
        }

        public override void GetInfoAboutTheRangeDependingOnCargo(
            int checkParam,
            double countOfLiters,
            ref double powerReserve)
        {
            var distance = this.HowManyKilometersCanTravel(countOfLiters);
            var overKilo = 20;
            var overPercent = checkParam > this.WeightCargo ? ((checkParam - this.WeightCargo) / overKilo) * this.OverPercent : 0;
            powerReserve = distance + ((distance / 100) * overPercent);
        }
    }
}
