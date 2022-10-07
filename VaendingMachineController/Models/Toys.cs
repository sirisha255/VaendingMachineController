using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaendingMachineController.Models
{
    public class Toys : Products
    {
        private int PricePerUnit;

        public string Color { get; set; }   
        public Toys(int id,string name,int pricePerUnit,string color): base(id,name,pricePerUnit)
        {
            Name = name;
            PricePerUnit = pricePerUnit;                   
            Color = color;
        }
        public override string Examine()
        {
            return $"Id : {Id} - Name : {Name} ({PricePerUnit}Kr ; {Color})\n";

        }

        public override string Use()
        {
            return " use only under the supervision of adults!\n";
        }
    }
}
