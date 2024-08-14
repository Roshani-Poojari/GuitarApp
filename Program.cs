using GuitarApp.Models;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //add guitar in list
            Inventory.AddGuitar("SN01", 20000, new GuitarSpec(Builder.FENDER, "Stratocaster", GType.ELECTRIC, Wood.ALDER, Wood.ALDER, 6));
            Inventory.AddGuitar("SN025", 15000, new GuitarSpec(Builder.TAYLOR, "314ce", GType.ACOUSTIC, Wood.SAPELE, Wood.SITKA_SPRUCE, 7));
            Inventory.AddGuitar("SN013", 13900, new GuitarSpec(Builder.MARTIN, "D-28", GType.ACOUSTIC, Wood.EAST_INDIAN_ROSEWOOD, Wood.SITKA_SPRUCE, 12));
            Inventory.AddGuitar("SN042", 8700, new GuitarSpec(Builder.IBANEZ, "RG550", GType.ELECTRIC, Wood.BASSWOOD, Wood.MAPLE, 11));
            Inventory.AddGuitar("SN087", 15000, new GuitarSpec(Builder.PRS, "Custom-24", GType.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, 6));
            Inventory.AddGuitar("SN097", 19000, new GuitarSpec(Builder.PRS, "Custom-24", GType.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, 7));


            //get guitar by serial number
            Guitar findGuitar = Inventory.GetGuitar("SN042");
            Console.WriteLine("Get Guitar by Serial Number\n");
            Console.WriteLine(findGuitar);

            //search guitar
            Console.WriteLine("\nSearch Guitar as per Customer's Preference\n");
            List<Guitar> searchGuitar = Inventory.SearchGuitar(new GuitarSpec(Builder.PRS, "CUSTOM-24", GType.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE, 6));
            //List<Guitar> searchGuitar = Inventory.SearchGuitar(new GuitarSpec(Builder.PRS, "Custom-20", GType.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE,11));
            if (searchGuitar.Count >0)
            {
                Console.WriteLine($"Erin, you might like these guitars .....\n\n");
                foreach (Guitar item in searchGuitar)
                    Console.WriteLine(item + "\n" +
                        "------------------------------------------\n");
            }
            else Console.WriteLine("Sorry, we couldn't find a suitable guitar for you");
        }
    }
}
/*
 Part 1 ->Guitar class - string(SerialNumber, Builder, Model, Type, BackWood, TopWood)
                       - double(Price)
        ->Inventory class - List<Guitar> guitars
                          - AddGuitar(serialNumber, price, builder, model, type, backWood, topWood)
                          - GetGuitar(serialNumber) returns Guitar
                          - SearchGuitar(Guitar(except sr no and price)) returns Guitar

Part 2 ->Enum - Builder, Type, Wood
       ->Guitar class - string(SerialNumber, Model)
                      - double(Price)
                      - Builder(Builder)
                      - Type(Type)
                      - Wood(BackWood, TopWood)
        ->Inventory class - List<Guitar> guitars
                          - AddGuitar(serialNumber, price, builder, model, type, backWood, topWood)
                          - GetGuitar(serialNumber) returns Guitar
                          - SearchGuitar(Guitar(except sr no and price)) returns List<Guitar> matchingGuitars, model- .ToLower()

Part 3 ->Enum - Builder, Type, Wood
       ->Guitar class - string(SerialNumber)
                      - double(Price)
                      - GuitarSpec(Spec)
       ->GuitarSpec class - string(Model)
                          - Builder(Builder)
                          - Type(Type)
                          - Wood(BackWood, TopWood) 
       ->Inventory class - List<Guitar> guitars
                          - AddGuitar(serialNumber, price, spec)
                          - GetGuitar(serialNumber) returns Guitar
                          - SearchGuitar(GuitarSpec) returns List<Guitar> matchingGuitars, model- .ToLower()

Part 4 ->Enum - Builder, Type, Wood
       ->Guitar class - string(SerialNumber)
                      - double(Price)
                      - GuitarSpec(Spec)
       ->GuitarSpec class - string(Model)
                          - Builder(Builder)
                          - Type(Type)
                          - Wood(BackWood, TopWood) 
                          - CheckMatch(GuitarSpec) returns bool
       ->Inventory class - List<Guitar> guitars
                          - AddGuitar(serialNumber, price, spec)
                          - GetGuitar(serialNumber) returns Guitar
                          - SearchGuitar(GuitarSpec) returns List<Guitar> matchingGuitars -* if(guitars.Spec.CheckMatch(gSpec))
 */