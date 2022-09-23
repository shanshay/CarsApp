using ConsoleApp5.Models;
using ConsoleApp5.Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cargoCar2 = new CargoCar2(200, 30, 120, 4, 400);
            var timeForTravel = cargoCar2.TimeTakesToRideDistance(700, 20, 1200, 430);
            var powerReserve = cargoCar2.PowerReserve(430, 500, 20);
        }
    }
}
