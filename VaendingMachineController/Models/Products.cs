using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaendingMachineController.Models
{
    public abstract class Products
    {
        private readonly int id;
        public int Id
        {
            get { return id; }
        }
        public string Name { get; set; }
        public string PricePerUnit { get; set; }
        public Products(int id, string name, int priceperunit)
        {
            this.id = id;
            Name = name;
            PricePerUnit = PricePerUnit;

        }
        public abstract string Examine();
        public abstract string Use();
        public override string ToString()
        {
            return Use();
        }
    }
}

    

