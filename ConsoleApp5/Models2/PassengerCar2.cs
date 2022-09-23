using ConsoleApp5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models2
{
    class PassengerCar2 :Car2
    {
        public int CountOfPassengers { get; set; }

        public PassengerCar2(
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
        public TimeSpan TimeTakesToRideDistance(
            double countOfLiters,
            int koefOverKilo,
            double distanceKm,
            int checkParam)
        {
            return GetTheAmountOfTimeItTakes(
                countOfLiters,
                this.CountOfPassengers,
                koefOverKilo,
                distanceKm,
                checkParam);
        }

        public double PowerReserve (
            int checkParam,
            double countOfLiters,
            int koefOverKilo)
        {
            return GetInfoAboutTheRangeDependingOnCargo(checkParam, countOfLiters, this.CountOfPassengers, koefOverKilo);
        }
    }
}
