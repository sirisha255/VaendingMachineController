using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaendingMachineController.Models
{
    public class Food : Products
    {
        public int Weight { get; set; }
        public Food(int id,string name,int priceperunit,int weight): base(id,name,priceperunit)
       {
            Name = name;
            PricePerUnit = PricePerUnit;
            Weight = weight;
        }
        public override string Examine()
        {
             return $"Id :{Id} - Name:{Name} ({PricePerUnit} kr ; {Weight}g)\n";
        }

        public override string Use()
        {
            return "Eat the Food\n";
        }
    }

}
