using System;
using System.Collections.Generic;

namespace Lab3_2Replacement
{
    class Program

    {


        static bool Continue()
        {
            while (true)
            {
                Console.WriteLine("Would you like to continue? (y/n)");
                string response = Console.ReadLine();
                response = response.ToLower();


                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    Console.WriteLine("Thank you for using the menu tool. Have a greaat day!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }

            }
        }


        static void Main(string[] args)
        {
            //do
            {
                Console.WriteLine("Deli Counter Menu");



                //display a list of menu items and prices
                //add a new menu item
                //remove a menu item
                //change the prices of a menu item


                // Use a Dictionary that maps strings to prices. Start out with three or four menu items hardcoded.
                Dictionary<string, double> menuItems = new Dictionary<string, double>();

                menuItems["Salad"] = 7.50;
                menuItems["Pizza"] = 5.50;
                menuItems["Fruit"] = 4.00;
                menuItems["Smoothie"] = 3.50;


                //List the menu when the program begins
                Console.WriteLine("Here is today's menu: ");
                Console.WriteLine("______________________");
                foreach (var item in menuItems)
                {

                    Console.WriteLine($"{item.Key}           {item.Value}");
                }

                Console.WriteLine();
                Console.WriteLine();

                //  Ask the user if they want to add a new item, remove an item, or change an item, or quit.
                //  The user will be entering a single letter: A to add a new item, R to remove an item, C to
                //  change an item, Q to quit.For this version, don’t put any validation yet.That will happen
                //  in step 9

                do
                {
                    Console.WriteLine("Would you like to modify the menu?");
                    Console.Write("Options: Please enter 'A' to add, 'R' to remove, 'C' to change an item price or 'Q' to quit: ");
                    string userResponse = Console.ReadLine();
                    userResponse = userResponse.ToUpper();
                    Console.WriteLine();

                    //If the user wants to add a new item, ask them what the item name is and the price
                    if (userResponse == "A")
                    {
                        Console.Write("Please enter item name: ");
                        string itemName = Console.ReadLine();
                        Console.Write("Plese enter item price: ");
                        double price = double.Parse(Console.ReadLine());
                        //Console.WriteLine(itemName);
                        //Console.WriteLine(price);
                        menuItems[itemName] = price;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Here is the updated menu: ");
                        Console.WriteLine("__________________________");
                        Console.WriteLine();
                        foreach (var item in menuItems)
                        {
                            Console.WriteLine($"{item.Key}           {item.Value}");
                        }



                    }
                    else if (userResponse == "R")
                    {

                        Console.Write("Please enter the name of the item you wish to remove: ");
                        string itemRem = Console.ReadLine();
                        menuItems.Remove(itemRem);
                        Console.WriteLine($"{itemRem} has been removed from the list");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Here is the updated menu: ");
                        Console.WriteLine("__________________________");
                        Console.WriteLine();
                        foreach (var item in menuItems)
                        {
                            Console.WriteLine($"{item.Key}           {item.Value}");
                        }


                    }
                    else if (userResponse == "C")
                    {
                        Console.Write("Please enter the name of the item that you wish to change: ");
                        string itemName = Console.ReadLine();



                        foreach (var item in menuItems)
                        {
                            if (itemName == item.Key)
                            {
                                Console.WriteLine($"The current price of {item.Key} is {item.Value}");

                            }
                        }

                        Console.WriteLine();
                        Console.Write("Please enter new item price: ");
                        double price = double.Parse(Console.ReadLine());
                        //Console.WriteLine(itemName);
                        //Console.WriteLine(price);
                        menuItems[itemName] = price;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Here is the updated menu: ");
                        Console.WriteLine("__________________________");
                        Console.WriteLine();
                        foreach (var item in menuItems)
                        {

                            Console.WriteLine($"{item.Key}           {item.Value}");
                        }



                    }
                    else if (userResponse == "Q")
                    {
                        Console.WriteLine("Thank you for using the menu tool. Have a great day!");
                    }
                } while (Continue());




            }
        }
    }
}
