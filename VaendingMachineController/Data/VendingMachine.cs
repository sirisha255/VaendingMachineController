using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using VaendingMachineController.Models;


namespace VaendingMachineController.Data
{
    public class VendingMachine : IVending
    {
        private readonly int[] coins = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        private List<Products> productArray = new List<Products> { };


        public int[] Coins
        {
            get
            {
                return coins;
            }
        }
        public List<Products> ProductArray
        {
            get
            {
                return productArray;

            }
            set
            {
                productArray = value;
            }

        }

        public object MoneyPool { get; internal set; }

        public Products Purchase(int productId)
        {
            foreach (Products p in productArray)
            {
                if (productItem.Id.Equals(productId))
                {
                    if (MoneyPool < productItem.PricePerUnit)
                    {
                        return null;

                    }
                    else
                    {
                        MoneyPool -= productItem.PricePerUnit;
                        return productItem;
                    }
                }
            }
        }
        public string ShowAll()
        {
            StringBuilder productInfo = new StringBuilder();
            productInfo.Append("------------------\n");
            return productInfo.ToString();
        }
        public void InsertMoney(int moneytoAdd)
        {
            if (coins.Contains(moneytoAdd))
            {
                MoneyPool += moneytoAdd
            }
            else
            {
                Console.WriteLine("money to be Added...it is not a valid denominator")
            }

        }
        public Dictionary<int, int> EndTransaction()
        {
            int remainingmoney = MoneyPool;
            MoneyPool = 0;

            Dictionary<int, int> result = new Dictionary<int, int>();
            foreach (int coins in coins)
            {
                moneyDictionary.Add(coins, remainingmoney / coins);
                remainingmoney %= coins;
            }
            return moneyDictionary;
        }

    }



}

                
     