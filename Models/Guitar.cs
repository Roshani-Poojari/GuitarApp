using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public GuitarSpec Spec { get; set; }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            SerialNumber = serialNumber;
            Price = price;
            Spec = spec;
        }
        public override string ToString()
        {
            return $"Serial No.: {SerialNumber}\n" +
                $"Price: {Price}\n" +
                $"Builder: {Spec.Builder}\n" +
                $"Model: {Spec.Model}\n" +
                $"Type: {Spec.Type}\n" +
                $"Backwood: {Spec.BackWood}\n" +
                $"Topwood: {Spec.TopWood}\n" +
                $"Number of Strings: {Spec.StringNumber}";
        }
    }
}
