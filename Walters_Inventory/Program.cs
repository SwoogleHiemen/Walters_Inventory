using System;
// Mason Walters
//IT112
//Notes:
//Behaviors not implemented and why:
namespace Walters_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Shipper s = new Shipper();
            int BicycleCounter = 0;
            int LawnMowerCounter = 0;
            int BaseballGloveCounter = 0;
            int CrackersCounter = 0;
            int counter = 0;
            string ProductType;
            ConsoleKeyInfo Pressed;
            bool Compute = false;
            IShippable[] Products = new IShippable[4];
            Products[0] = new Bicycles();
            Products[1] = new Lawn_Mowers();
            Products[2] = new Baseball_Gloves();
            Products[3] = new Crackers();


            do
            {
                Console.Clear();
                Console.WriteLine("Choose from the following options:(enter the number...)");
                Console.WriteLine("1. Add a Bicycle to the Shipment");
                Console.WriteLine("2. Add a Lawn Mower to the Shipment");
                Console.WriteLine("3. Add a Baseball Glove to the shipment");
                Console.WriteLine("4. Add Crackers to the shipment");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");
                Pressed = Console.ReadKey();
                Console.Clear();
                if (Pressed.Key == ConsoleKey.D1)
                 {
                    ProductType = Products[0].Product;
                    s.Add(ProductType, counter, BicycleCounter, LawnMowerCounter, CrackersCounter, BaseballGloveCounter);
                    counter = s.CounterMethod();
                    BicycleCounter = s.BicycleCounterMethod();
                    Console.WriteLine("1 Bicycle has been added");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                }
                if (Pressed.Key == ConsoleKey.D2)
                {
                    ProductType = Products[1].Product;
                    s.Add(ProductType, counter, BicycleCounter, LawnMowerCounter, CrackersCounter, BaseballGloveCounter);
                    counter = s.CounterMethod();
                    LawnMowerCounter = s.LawnMowerCounterMethod();
                    Console.WriteLine("1 Lawn Mower has been added");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                }
                if (Pressed.Key == ConsoleKey.D3)
                {
                    ProductType = Products[2].Product;
                    s.Add(ProductType, counter, BicycleCounter, LawnMowerCounter, CrackersCounter, BaseballGloveCounter);
                    counter = s.CounterMethod();
                    BaseballGloveCounter = s.BaseballGloveCounterMethod();
                    Console.WriteLine("1 Baseball Glove has been added");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                }
                if (Pressed.Key == ConsoleKey.D4)
                {
                    ProductType = Products[3].Product;
                    s.Add(ProductType, counter, BicycleCounter, LawnMowerCounter, CrackersCounter, BaseballGloveCounter);
                    counter = s.CounterMethod();
                    CrackersCounter = s.CrackersCounterMethod();
                    Console.WriteLine("1 Crackers has been added");
                    Console.WriteLine("Press any key to return to the menu");
                    Console.ReadKey();
                }
                if (Pressed.Key == ConsoleKey.D5)
                {
                    Console.WriteLine("Shipment manifest:");
                    if (BicycleCounter == 1)
                    {
                        Console.WriteLine(BicycleCounter + " " + Products[0].Product);
                    }
                    else
                    {
                        Console.WriteLine(BicycleCounter + " " + Products[0].Product + "s");
                    }
                    if (LawnMowerCounter == 1)
                    {
                        Console.WriteLine(LawnMowerCounter + " " + Products[1].Product);
                    }
                    else
                    {
                        Console.WriteLine(LawnMowerCounter + " " + Products[1].Product + "s");
                    }

                    if (BaseballGloveCounter == 1)
                    {
                        Console.WriteLine(BaseballGloveCounter + " " + Products[2].Product);
                    }
                    else
                    {
                        Console.WriteLine(BaseballGloveCounter + " " + Products[2].Product + "s");
                    }

                    Console.WriteLine(CrackersCounter + " " + Products[3].Product);//Crackers is always plural...
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                if (Pressed.Key == ConsoleKey.D6)
                {
                    Compute = true;
                    break;

                }
            } while (counter != 10);
            do
            {
                if (Compute == true)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("you are at your item limit");
                Console.WriteLine("5. List Shipment Items");
                Console.WriteLine("6. Compute Shipping Charges");
                Pressed = Console.ReadKey();
                Console.Clear();
                if (Pressed.Key == ConsoleKey.D5)
                {
                    Console.WriteLine("Shipment manifest:");
                    if (BicycleCounter == 1)
                    {
                        Console.WriteLine(BicycleCounter + " " + Products[0].Product);
                    }
                    else
                    {
                        Console.WriteLine(BicycleCounter + " " + Products[0].Product + "s");
                    }
                    if (LawnMowerCounter == 1)
                    {
                        Console.WriteLine(LawnMowerCounter + " " + Products[1].Product);
                    }
                    else
                    {
                        Console.WriteLine(LawnMowerCounter + " " + Products[1].Product + "s");
                    }

                    if (BaseballGloveCounter == 1)
                    {
                        Console.WriteLine(BaseballGloveCounter + " " + Products[2].Product);
                    }
                    else
                    {
                        Console.WriteLine(BaseballGloveCounter + " " + Products[2].Product + "s");
                    }

                    Console.WriteLine(CrackersCounter + " " + Products[3].Product);//Crackers is always plural...
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                if (Pressed.Key == ConsoleKey.D6)
                {
                    break;
                }
                Console.Clear();
            } while (counter == 10);
            decimal TotalCharge = (BicycleCounter * Products[0].ShipCost) + (LawnMowerCounter * Products[1].ShipCost)
               + (BaseballGloveCounter * Products[2].ShipCost) + (CrackersCounter * Products[3].ShipCost);
            Console.WriteLine("Total Shipping cost for this order is $" + Math.Round(TotalCharge, 2));
        }

    }
    
}
