using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    public class Car2
    {
        //id
        public int Id { get; set; }

        //max speed
        public int SpeedKmPerHour { get; set; }

        public int OverPercent { get; set; }

        //average fuel
        public double AverageFuel { get; set; }

        //volume of tank 
        public double FuelTankVolume { get; set; }

        //type vehicle 
        public VehicleTypeEnum Type { get; set; }

        public Car2(
            int speedKmPerHour,
            double averageFuel,
            double fuelTankVolume,
            int overPercent)
        {
            this.SpeedKmPerHour = speedKmPerHour;
            this.AverageFuel = averageFuel;
            this.FuelTankVolume = fuelTankVolume;
            this.OverPercent = overPercent;
        }

        // how far the car can travel on a full tank or on the remaining amount of fuel in the tank
        public double HowManyKilometersCanTravel(double countOfLiters)
        {
            if (this.AverageFuel == 0)
            {
                throw new Exception("Average fuel must be > 0");
            }
            return countOfLiters / this.AverageFuel;
        }

        // display current information about the state of the power reserve depending on passengers and cargo
        public double GetInfoAboutTheRangeDependingOnCargo(
            int checkParam,
            double countOfLiters,
            int weight,
            int koefOverKilo)            
        {
            var distance = this.HowManyKilometersCanTravel(countOfLiters);

            //if it's passenger car pass 1 (passenger)
            var koefOfOver = (checkParam - weight) / koefOverKilo; 
            
            var overPercent = checkParam > weight ? ((checkParam - weight) / koefOfOver) * this.OverPercent : 0;

            return distance + ((distance / 100) * overPercent);
        }

        //based on the parameters of the amount of fuel
        //and the calculation is set for how much the car will overcome it
        public TimeSpan GetTheAmountOfTimeItTakes(
            double countOfLiters,
            int weight,
            int koefOverKilo,
            double distanceKm,
            int checkParam)
        {
            var distance = this.GetInfoAboutTheRangeDependingOnCargo(checkParam, countOfLiters, weight, koefOverKilo);

            return TimeSpan.FromHours(Convert.ToDouble(distance / this.SpeedKmPerHour));
        }
    }
}
