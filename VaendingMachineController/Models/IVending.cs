using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaendingMachineController.Data;

namespace VaendingMachineController.Models
{
    internal abstract class IVending
    {
        public Products Purchase(int ProductId);
        public String ShowAll();
        public void InsertMoney(int moneyToAdd);
        public Dictionary<int, int> EndTransaction();
    }
        
    }
}
