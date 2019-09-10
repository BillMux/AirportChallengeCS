using System;
using System.Collections;

namespace AirportClass
{
    public class Airport
    {
        static void Main()
        {
            //something should go here?
        }

        public ArrayList hangar = new ArrayList();
        public const int hangarCapacity = 10;

        public ArrayList Land(string plane)
        {
            if (hangar.Count >= hangarCapacity)
            {
                Console.WriteLine("Hangar is at capacity!");
                return hangar;
            }
            hangar.Add(plane);
            return hangar;
        }

        public void TakeOff(string plane)
        {
            if (hangar.Count == 0)
            {
                Console.WriteLine("No planes!");
            }
            hangar.Remove(plane);
        }
    }
}