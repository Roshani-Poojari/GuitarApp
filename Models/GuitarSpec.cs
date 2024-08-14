using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class GuitarSpec
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public GType Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int StringNumber { get; set; }

        public GuitarSpec(Builder builder, string model, GType type, Wood backWood, Wood topWood, int stringNumber)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            StringNumber = stringNumber;
        }
        public bool CheckMatch(GuitarSpec gSpec)
        {
            if (Builder == gSpec.Builder &&
                Model.ToLower() == gSpec.Model.ToLower() &&
                Type == gSpec.Type &&
                BackWood == gSpec.BackWood &&
                TopWood == gSpec.TopWood &&
                StringNumber == gSpec.StringNumber)
                return true;
            return false;
        }
    }
}
