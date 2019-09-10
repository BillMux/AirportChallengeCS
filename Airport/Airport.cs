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

        public ArrayList Land(string plane)
        {
            hangar.Add(plane);
            return hangar;
        }

        public void TakeOff(string plane)
        {
            hangar.Remove(plane);
        }
    }
}