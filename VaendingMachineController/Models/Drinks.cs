using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaendingMachineController.Models
{
    public class Drinks : Products
    {
        public int volume { get; set; }
        public Drinks(int id, string name, int priceperunit, int volume)
        {
            Name = name;
            PricePerUnit = PricePerUnit;
            volume = volume;
        }
        public override string Examine()
        {
            return $"Id: {Id}  - Name: {Name} ({PricePerUnit} Kr ; {volume} ml)\n";
        }

        public override string Use()
        {
            return "Drink the drink ";

        }
    }
}
