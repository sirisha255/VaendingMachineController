using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;
using VaendingMachineController.Data;
using VaendingMachineController.Models;

namespace VaendingMachineController
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine Vmachine = new VendingMachine();
            Vmachine.ProductArray.Add(new Food(1, "cake", 50, 50));
            Vmachine.ProductArray.Add(new Food(2, "Croissant", 60, 50));
            Vmachine.ProductArray.Add(new Food(3, "chips", 50, 200));
            Vmachine.ProductArray.Add(new Food(4, "cookies", 40, 400));
            Vmachine.ProductArray.Add(new Drinks(5, "Coke", 50, 500));
            Vmachine.ProductArray.Add(new Drinks(6, "juice", 30, 100));
            Vmachine.ProductArray.Add(new Drinks(7, "Sprite", 40, 100));
            Vmachine.ProductArray.Add(new Toys(8, "softtoy", 50, "pink"));
            Vmachine.ProductArray.Add(new Toys(9, "dino", 50, "yellow"));

            char userSelection;
            Dictionary<int, int> moneyDictionary;
            do
            {
                Console.Clear();
                Console.WriteLine(Vmachine.ShowAll());
                Console.WriteLine(" Balance Money :{Vmachine.MoneyPool} Kr");
                Console.WriteLine(" Press numbers to buy an item, I to insert money or F to Finish purchase");
                userSelection = Convert.ToChar(Console.ReadLine());

                switch (userSelection)
                {
                    case '1':
                        BuyItemFromVendingMachine(Vmachine, 1);
                        break;
                    case '2':
                        BuyItemFromVendingMachine(Vmachine, 2);
                        break;
                    case '3':
                        BuyItemFromVendingMachine(Vmachine, 3);
                        break;
                    case '4':
                        BuyItemFromVendingMachine(Vmachine, 4);
                        break;
                    case '5':
                        BuyItemFromVendingMachine(Vmachine, 5);
                        break;
                    case '6':
                        BuyItemFromVendingMachine(Vmachine, 6);
                        break;
                    case '7':
                        BuyItemFromVendingMachine(Vmachine, 7);
                        break;
                    case '8':
                        BuyItemFromVendingMachine(Vmachine, 8);
                        break;
                    case '9':
                        BuyItemFromVendingMachine(Vmachine, 9);
                        break;


                    case 'I':
                        Console.WriteLine("Enter The Money Sum to Be Added (1000, 500, 100, 50, 20, 10, 5 or 1)");
                        Vmachine.InsertMoney(Convert.ToInt32(Console.ReadLine()));
                        continue;
                    case 'F':
                        Console.WriteLine($"Returned {Vmachine.MoneyPool} kr");
                        moneyDictionary = Vmachine.EndTransaction();
                        foreach (var pair in moneyDictionary)
                        {
                            Console.WriteLine($"{pair.Key} banknotes/coins: {pair.Value}");
                        }
                        return;
                }
                Console.WriteLine("Press <Spacebar> to Continue... ");
                while (Console.ReadKey().Key != ConsoleKey.Spacebar) { }
            } while (true);
        }

        public static void BuyItemFromVendingMachine(VendingMachine Vmachine, int itemId)
        {
            Products boughtProduct;
            boughtProduct = Vmachine.Purchase(itemId);
            if (boughtProduct == null)
            {
                Console.WriteLine("Not Enough Money! Insert More Money And Try Again.");
            }
            else
            {
                Console.WriteLine($"You Bought {Vmachine.ProductArray[itemId - 1].Name}");
                Console.WriteLine(boughtProduct);
            }
        }
    }
}            