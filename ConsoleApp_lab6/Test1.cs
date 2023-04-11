using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_lab6
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void Walk()
        {
            Console.WriteLine("The person is walking.");
        }
    }

    public class Builder : Human
    {
        public string Trade { get; set; }
        public int YearsOfExperience { get; set; }

        public void Build()
        {
            Console.WriteLine("The builder is building.");
        }
    }

    public class Sailor : Human
    {
        public string Rank { get; set; }
        public string Vessel { get; set; }

        public void Sail()
        {
            Console.WriteLine("The sailor is sailing.");
        }
    }

    public class Pilot : Human
    {
        public string LicenseNumber { get; set; }
        public string AircraftType { get; set; }

        public void Fly()
        {
            Console.WriteLine("The pilot is flying.");
        }
    }
}
