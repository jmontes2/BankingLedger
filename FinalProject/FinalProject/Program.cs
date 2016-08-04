// File:  FinalProject.cs (Inventory Project)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    struct Item
    {
        public string strItem;
        public string strDescription;
        public double price;
        public int    quantity;
        public double ourCost;
        public double itemValue;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create array of structs and variables
            Item[] items = new Item[100];
            int counter = 0;
            int refNumber;
            int itemIndex;
            string itemToChg;

            while (true)
            {
                // Initialize variables per iteration
                refNumber = 0;
                itemIndex = -1;
                itemToChg = null;

                // Menu
                Console.WriteLine("1. Add an item");
                Console.WriteLine("2. Change an item (by giving its item number");
                Console.WriteLine("3. Delete an item (by giving its item number");
                Console.WriteLine("4. List all items in the database");
                Console.WriteLine("5. Quit");
                Console.Write("\nPlease choose an option from the list(1, 2, 3, 4, or 5): ");
                string choice = Console.ReadLine();

                // Take action depending on selection
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Add Item \n");
                        if (counter > 99)   // zero-based, max is 100
                        {
                            Console.Write("Maximum of 100 items allowed.  ");
                            break;
                        }
                        Console.Write("Item number: ");
                        items[counter].strItem = Console.ReadLine();
                        Console.Write("Item description: ");
                        items[counter].strDescription = Console.ReadLine();
                        Console.Write("Item price: ");
                        items[counter].price = double.Parse(Console.ReadLine());
                        Console.Write("Item quatity: ");
                        items[counter].quantity = int.Parse(Console.ReadLine());
                        Console.Write("Our cost: ");
                        items[counter].ourCost = double.Parse(Console.ReadLine());
                        items[counter].itemValue = items[counter].price * items[counter].quantity;
                        counter++;      // increment counter
                        Console.Write("\nItem added.  ");
                        break;
                    case "2":
                        Console.WriteLine("Change Item \n");
                        Console.Write("Item number: ");
                        itemToChg = Console.ReadLine();

                        // Find item
                        foreach (Item x in items)
                        {
                            if (x.strItem == itemToChg)
                            {
                                itemIndex = refNumber;
                            }
                            refNumber++;
                        }
                        if (itemIndex == -1)
                        {
                            Console.Write("\n*** Item not found.  ");
                            break;
                        }
                        // New values
                        Console.Write("New Item description: ");
                        items[itemIndex].strDescription = Console.ReadLine();
                        Console.Write("New Item price: ");
                        items[itemIndex].price = double.Parse(Console.ReadLine());
                        Console.Write("New Item quatity: ");
                        items[itemIndex].quantity = int.Parse(Console.ReadLine());
                        Console.Write("New Our cost: ");
                        items[itemIndex].ourCost = double.Parse(Console.ReadLine());
                        items[itemIndex].itemValue = items[itemIndex].price * items[itemIndex].quantity;
                        Console.Write("\nItem changed.  ");
                        break;
                    case "3":
                        Console.WriteLine("Delete Item \n");
                        Console.Write("Item number: ");
                        itemToChg = Console.ReadLine();

                        // Find item
                        foreach (Item x in items)
                        {
                            if (x.strItem == itemToChg)
                            {
                                itemIndex = refNumber;
                            }
                            refNumber++;
                        }
                        if (itemIndex == -1)
                        {
                            Console.Write("\n*** Item not found.  ");
                            break;
                        }
                        // If there is only one item in the array, we only need to clear its values
                        if (itemIndex == 0 && items.Length == 1)
                        {
                            Array.Clear(items, 0, items.Length);
                        }
                        else
                        {
                            // We delete an item by copying all values to a new array, EXCEPT item being deleted

                            // Create a new array
                            Item[] newArray = new Item[100];

                            // If item being deleted is the first item in array, copy everything after the current index position
                            if (itemIndex == 0)
                            {
                                Array.Copy(items, itemIndex + 1, newArray, 0, items.Length - 1);
                            }
                            else
                            {
                                // Since item being deleted is not the first item in array, copy all before item, then all after
                                // Keep in mind that arrays are zero-based when using itemIndex
                                Array.Copy(items, 0, newArray, 0, itemIndex);
                                Array.Copy(items, itemIndex + 1, newArray, itemIndex, items.Length - itemIndex - 1);
                            }

                            //// For testing purposes only (Dan: In case you want to see both arrays, uncomment this section)
                            //refNumber = 0;
                            //Console.WriteLine("Old array:");
                            //foreach (Item x in items)
                            //{
                            //    Console.WriteLine("{0,-10} {1,-10} {2,-12} {3,10:C} {4,-10} {5,10:C} {6,12:C}", refNumber, x.strItem, x.strDescription, x.price, x.quantity, x.ourCost, x.itemValue);
                            //    refNumber++;
                            //}
                            //refNumber = 0;
                            //Console.WriteLine("New array:");
                            //foreach (Item x in newArray)
                            //{
                            //    Console.WriteLine("{0,-10} {1,-10} {2,-12} {3,10:C} {4,-10} {5,10:C} {6,12:C}", refNumber, x.strItem, x.strDescription, x.price, x.quantity, x.ourCost, x.itemValue);
                            //    refNumber++;
                            //}
                            //Console.ReadLine();

                            // Set new stack to be the current stack
                            items = newArray;
                        }
                        Console.Write("\nItem deleted.  ");
                        break;
                    case "4":
                        Console.WriteLine("List All Items \n");
                        Console.WriteLine("Ref#       Item       Description       Price Quantity     Our Cost        Value");
                        Console.WriteLine("--------------------------------------------------------------------------------");
                        foreach (Item x in items)
                        {
                            if (x.strItem != null)
                            {
                                Console.WriteLine("{0,-10} {1,-10} {2,-12} {3,10:C} {4,-10} {5,10:C} {6,12:C}", refNumber, x.strItem, x.strDescription, x.price, x.quantity, x.ourCost, x.itemValue);
                                refNumber++;
                            }
                        }
                        Console.WriteLine("");
                        break;
                    case "5":
                        Console.WriteLine("\nQuit... Press <Enter> \n");
                        Console.ReadLine();
                        return;
                    default:
                        Console.Write("\n*** Your choice is not in the list.  ");
                        break;
                }
                Console.WriteLine("Press <Enter> \n");    // skip a line to display menu again
                Console.ReadLine();
            }
        }
    }
}