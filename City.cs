using System;
using System.Collections.Generic;

namespace urban_planner
{
    class City
    {
        // Private fields
        private string _mayor;

        // Public Props
        public string CityName { get; set; }
        public int YearEstablished { get; set; }
        public List<Building> BuildingList = new List<Building>();


        // Constructors
        public City(string cityname, int yearEst, string mayorname)
        {
            CityName = cityname;
            YearEstablished = yearEst;
            _mayor = mayorname;
        }

        // Methods
        public void AddBuildingToCity(Building buildingName)
        {
            BuildingList.Add(buildingName);
        }

        public void PrintCityInfo()
        {
            Console.WriteLine(CityName);
            Console.WriteLine("_____________");
            Console.WriteLine("_____________");
            Console.WriteLine($"The mayor of {CityName} is {_mayor}");
            Console.WriteLine($"It was established in {YearEstablished}");
            Console.WriteLine("_____________");
            Console.WriteLine("_____________");
            Console.WriteLine("The buildings in this city include:");
            BuildingList.ForEach(building => building.PrintInfo());
        }


    }
}
