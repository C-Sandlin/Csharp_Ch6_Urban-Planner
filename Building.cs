using System;

namespace urban_planner
{
    class Building
    {
        // Private fields
        private string _designer = "Colin Sandlin";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;

        // Public Props
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        // Constructors
        public Building(string inputAddress)
        {
            _address = inputAddress;
        }

        // Methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string ownerName)
        {
            _owner = ownerName;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{_address}");
            Console.WriteLine("_______________________");
            Console.WriteLine($"Designed by the famed {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic feet of space");
        }

    }
}
