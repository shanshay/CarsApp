using ConsoleApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models2
{
    public class CargoCar2 : Car2
    {
        public int WeightCargo { get; set; }

        public CargoCar2(
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

        public TimeSpan TimeTakesToRideDistance(
            double countOfLiters,
            int koefOverKilo,
            double distanceKm,
            int checkParam)
        {
            return GetTheAmountOfTimeItTakes(
                countOfLiters, 
                this.WeightCargo, 
                koefOverKilo, 
                distanceKm, 
                checkParam);
        }
        public double PowerReserve(
            int checkParam,
            double countOfLiters,
            int koefOverKilo)
        {
            return GetInfoAboutTheRangeDependingOnCargo(checkParam, countOfLiters, this.WeightCargo, koefOverKilo);
        }
    }
}
