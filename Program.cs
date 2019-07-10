using System;
using System.Collections.Generic;

namespace urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            var EmpireState = new Building("20 W 34th St, New York, NY 10001")
            {
                Stories = 102,
                Depth = 450,
                Width = 424

            };

            var DwellTower = new Building("500 Main St, San Jose, CA 35244")
            {
                Stories = 4,
                Depth = 210,
                Width = 145
            };

            EmpireState.Construct();
            EmpireState.Purchase("Donald Trump");

            DwellTower.Construct();
            DwellTower.Purchase("Jason Collum");

            var myCity = new List<Building>()
            {
                EmpireState, DwellTower
            };

            myCity.ForEach(building =>
            {
                Console.WriteLine("                ");
                building.PrintInfo();
            });
        }
    }
}
