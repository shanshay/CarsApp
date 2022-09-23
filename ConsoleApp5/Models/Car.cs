using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    public class Car
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

        public Car (
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

        //  display current information about the state of the power reserve depending on passengers and cargo
        public virtual void GetInfoAboutTheRangeDependingOnCargo(
            int checkParam, 
            double countOfLiters,
            ref double powerReserve)
        {
        }

        //based on the parameters of the amount of fuel
        //and the calculation is set for how much the car will overcome it
        public TimeSpan GetTheAmountOfTimeItTakes(
            double countOfLiters, 
            double distanceKm, 
            int checkParam)
        {
            double distance = 0;
            this.GetInfoAboutTheRangeDependingOnCargo(checkParam, countOfLiters, ref distance);
            return TimeSpan.FromHours(Convert.ToDouble(distance / this.SpeedKmPerHour));
        }
    }
}
