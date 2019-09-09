using System;
using System.Collections;

namespace AirportClass
{
    public class Airport
    {
        static void Main()
        {

        }

        public ArrayList hangar = new ArrayList();

        public ArrayList Land(string plane)
        {
            hangar.Add(plane);
            return hangar;
        }
    }
}
