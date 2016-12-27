// Name: Michael Ray
// Professor Cascioli
// GDAPS2
// Class: Main Program
// I don't know how many points i will get off for doing this project differently than the way
// the example output shows but it was werth. You can type in print and count manually just to
// that it works but i didnt add it in the main display cause it already shows that
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int quit = 0;
            CustomLinkedList names = new CustomLinkedList();
            // Preset names in the list, can clear it later
            names.Add("Michael");
            names.Add("Wilbert");
            names.Add("Sam");
            names.Add("Pizza Guy");
            names.Add("What are those");
            names.Add("Swiggity");
            do
            {
                Console.Clear();
                string choice;
                Console.WriteLine("Names:");
                for (int i = 1; i <= names.Count; i++)
                {
                    Console.WriteLine(i + ") " + names.GetData(i));
                }
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?\n(1)Add a name\n(2)Remove a name\n(3)Insert a name\n(4)Print the names in reverse\n(5)Scramble the names in the list\n(6)Clear the list of names\n(Type in '1', '2', '3'...'quit' then 'ENTER'): ");
                choice = Console.ReadLine();
                choice = choice.ToLower();
                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("Please type in the name you want to add:");
                            string name = Console.ReadLine();
                            names.Add(name);
                            Console.WriteLine("Name added!!!(Press Enter to continue)");
                            Console.ReadLine();
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Type in the number of the name you want to delete: ");
                            string strIndex = Console.ReadLine();
                            int index;
                            bool parsed = int.TryParse(strIndex, out index);
                            if(parsed == false)
                            {
                                Console.WriteLine("What you entered isn't valid(Press Enter to countinue...)");
                            }
                            else
                            {
                                names.RemoveAt(index);
                                Console.WriteLine("Nmae Removed!!!(Press Enter to continue...)");
                                Console.ReadLine();
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("What name would you like to enter?");
                            string name = Console.ReadLine();
                            Console.WriteLine("Where would you like to insert it?");
                            string strIndex = Console.ReadLine();
                            int index;
                            bool parsed = int.TryParse(strIndex, out index);
                            if (parsed == false)
                            {
                                Console.WriteLine("What you entered isn't valid(Press Enter to countinue...)");
                            }
                            else
                            {
                                names.Insert(name, index);
                            }

                            break;
                        }
                    case "4":
                        {
                            names.PrintReversed();
                            Console.ReadLine();
                            break;
                        }
                    case "5":
                        {
                            names.Scramble();
                            break;
                        }
                    case "6":
                        {
                            names.Clear();
                            break;
                        }
                    case "print":
                        {
                            Console.WriteLine("Names:");
                            for (int i = 1; i <= names.Count; i++)
                            {
                                Console.WriteLine(i + ") " + names.GetData(i));
                            }
                            Console.ReadLine();
                            break;
                        }
                    case "count":
                        {
                            Console.WriteLine("Number of items in the list: " + names.Count);
                            Console.ReadLine();
                            break;
                        }
                    case "quit":
                        {
                            quit += 1;
                            break;
                        }
                    default: 
                        {
                            Console.WriteLine("What you entered isn't valid!!!!!!!!(Press Enter to continue...)");
                            Console.ReadLine();
                            break;
                        }
                        
                }

            } while (quit == 0);
        }
    }
}
