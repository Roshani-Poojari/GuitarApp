using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Inventory
    {
        public static List<Guitar> guitars = new List<Guitar>();

        public static void AddGuitar(string serialNumber, double price, GuitarSpec guitarSpec)
        {
            Guitar guitar = new Guitar(serialNumber, price, guitarSpec);
            guitars.Add(guitar);
        }
        public static Guitar GetGuitar(string serialNumber)
        {
            Guitar findGuitar = null;
            foreach (Guitar guitar in guitars)
            {
                if (guitar.SerialNumber.ToLower() == serialNumber.ToLower())
                    findGuitar = guitar;
            }
            return findGuitar;
        }
        public static List<Guitar> SearchGuitar(GuitarSpec gSpec) 
        {
            List<Guitar> matchingGuitars = new List<Guitar>();           
            foreach (Guitar guitar in guitars)
            {
                if (guitar.Spec.CheckMatch(gSpec))
                    matchingGuitars.Add(guitar);
            }
            return matchingGuitars;
        }
        
    }
}
