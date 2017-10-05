using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresGroupAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare global variables. Don't forget to comment!!
            int iDecision;
            Stack<string> myStack = new Stack<string>(); //Stack for option 1
            Stack<string> myHoldStack = new Stack<string>(); //this is used when deleting stack item/it's for option 1



            do //main menu
            {//do while 
                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit");

                iDecision = Convert.ToInt32(Console.ReadLine());

                switch (iDecision) //determines which structure to use
                {
                    case 1: //Logic for Stack

                        //global variables for stack options!
                        int iMenu = 0;
                        int i;
                        string sEntry = "New Entry ";

                        do
                        {
                            Console.WriteLine(); //blank line
                            Console.WriteLine("1. Add one time to Stack");
                            Console.WriteLine("2. Add Huge List of Items to Stack");
                            Console.WriteLine("3. Display Stack");
                            Console.WriteLine("4. Delete from Stack");
                            Console.WriteLine("5. Clear Stack");
                            Console.WriteLine("6. Search Stack");
                            Console.WriteLine("7. Return to Main Menu");

                            iMenu = Convert.ToInt32(Console.ReadLine());

                            switch (iMenu) //determines which options to use
                            {
                                case 1: //add item
                                    Console.WriteLine(); //blank line
                                    Console.Write("Enter one item into stack:");
                                    myStack.Push(Console.ReadLine());

                                    break;
                                case 2: //adds huge list

                                    for (i = 0; myStack.Count > 0; i++)
                                    {
                                        myStack.Pop(); //clearing data structure
                                    }
                                    i = 1; //reset counter

                                    for (i = 1; i < 2001; i++) //create huge list of "new entry"
                                    {
                                        myStack.Push(sEntry + Convert.ToString(i));
                                        //Console.WriteLine(myStack.Peek());
                                    }

                                    Console.WriteLine(); //blank line
                                    Console.WriteLine("List Created.");

                                    break;
                                case 3: //diplays entire list

                                    Console.WriteLine(); //blank line
                                    foreach (string sDisplay in myStack)
                                    {
                                        Console.WriteLine(sDisplay); //writing each item in Stack
                                    }

                                    break;
                                case 4: //deletes one item

                                    string sDelete;
                                    Boolean bDelete = false; //to determine if deleted
                                    Console.WriteLine(); //blank line
                                    Console.WriteLine("Enter item you want to delete: ");
                                    Console.Write("New Entry #");

                                    sDelete = sEntry + Convert.ToString(Console.ReadLine());

                                    while (myStack.Count > 0)
                                    {

                                        //Remove iDelete from the stack
                                        if (myStack.Peek() == sDelete)
                                        {
                                            myStack.Pop();
                                            Console.WriteLine(sDelete + " Has been deleted"); //if deleted
                                            bDelete = true;
                                        }
                                        else
                                        {
                                            //if it is not iDelete then push it to a new stack
                                            myHoldStack.Push(myStack.Pop());
                                        }
                                    }

                                    //Copy the new stack back to the old stack since 5 has been removed
                                    //It copies in the original order
                                    for (int iCount = 0; myHoldStack.Count > 0; iCount++)
                                    {
                                        myStack.Push(myHoldStack.Pop());
                                    }

                                    if (bDelete == false) //if item not found
                                    {
                                        Console.WriteLine("NOTHING DELETED because item not found");
                                    }
                                    else
                                    {
                                        //nothing
                                    }

                                    break;
                                case 5: //clears stack

                                    Console.WriteLine();  //blank line
                                    //for loop clears all of stack
                                    for (int iCount = 0; myStack.Count > 0; iCount++)
                                    {
                                        myStack.Pop(); //deletes items
                                    }

                                    Console.WriteLine("List has been cleared.");

                                    break;
                                case 6: //searches for one item

                                    string sSearch;
                                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); //stopwatch!
                                    Console.WriteLine(); //blank line
                                    Console.WriteLine("Enter item you want to search for: ");
                                    Console.Write("New Entry #");

                                    sSearch = sEntry + Convert.ToString(Console.ReadLine());
                                    sw.Start(); //this starts the stopwatch

                                    Boolean bFound = false;


                                    if (myStack.Contains(sSearch))
                                    {
                                        Console.WriteLine(); //blank line
                                        Console.WriteLine("FOUND: " + sSearch);
                                        bFound = true;
                                    }
                                    else
                                    {
                                        //nothing
                                    }

                                    if (bFound == false)
                                    {
                                        Console.WriteLine(); //blank line
                                        Console.WriteLine("This item is not found in search");
                                    }
                                    else
                                    {
                                        //nothing
                                    }
                                    sw.Stop(); //this stops the stopwatch

                                    TimeSpan ts = sw.Elapsed; //assigns the time elapsed
                                    Console.WriteLine("Time elapsed in search: " + ts); //displays the stopwatch time

                                    break;
                                case 7: //leaves stack and goes back to main menu

                                    //not sure if i need this case... the do while loop kicks me out when i choose 7
                                    break;
                            }

                        } while (iMenu != 7);

                        break;
                    case 2:
                        //Logic for Queue


                        break;

                    case 3:
                        //Logic for Dictionary
                        int iChoice;
                        Dictionary<string, int> Dictionary = new Dictionary<string, int>();

                        //display dictionary menu
                        do  
                        {
                            Console.WriteLine();
                            Console.WriteLine("Dictionary Menu");
                            Console.WriteLine("---------------");
                            Console.WriteLine("1. Add one item to Dictionary");
                            Console.WriteLine("2. Add huge List of Items to Dictionary");
                            Console.WriteLine("3. Display Dictionary");
                            Console.WriteLine("4. Delete from Dictionary");
                            Console.WriteLine("5. Clear Dictionary");
                            Console.WriteLine("6. Search Dictionary");
                            Console.WriteLine("7. Return to main menu");
                            Console.WriteLine();

                            iChoice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            if (iChoice == 1)
                            {
                                //Add one item to dictionary

                                string sName;
                                Boolean b = false;
                                int iValue = 0;

                                //ask for the name of the item
                                Console.WriteLine("What is the name of the item you would like to add to the dictionary");

                                sName = Console.ReadLine();
                                Console.WriteLine();

                                Console.WriteLine("What value is associated with this item? (Please enter a number)");

                                while (b == false)
                                {
                                    try//to make sure a number is entered for the value
                                    {
                                        iValue = Convert.ToInt32(Console.ReadLine());
                                        b = true;
                                    }
                                    catch (Exception e1)
                                    {
                                        Console.WriteLine("Please enter a valid #");
                                    }

                                }

                                //Load item into dictionary
                                Dictionary.Add(sName, iValue);
                            }

                            else if (iChoice == 2)
                            {
                                //Add huge list of items to dictionary
                                int iLength = 2001;
                                Dictionary.Clear;

                                //load up the list with values
                                for (int iCount = 0; iCount < iLength; iCount++)
                                {
                                    Dictionary.Add("New Entry " + (iCount+1), (iCount +1));
                                }

                            }
                            else if (iChoice == 3)
                            {
                                //display dictionary
                                Console.WriteLine("Name\t\tValue");
                                Console.WriteLine("----\t\t-----");
                                foreach (KeyValuePair<string, int> kvp in Dictionary)
                                {
                                    Console.WriteLine(kvp.Key + "\t\t" + kvp.Value);
                                }
                            }
                            else if (iChoice == 4)
                            {
                                //delete from dictionary
                                string sDelete;
                                Boolean b3 = false;

                                try
                                {
                                    Console.WriteLine("What item would you like to clear from the dictionary?");
                                    sDelete = Console.ReadLine();
                                    Dictionary.Remove(sDelete);
                                    Console.WriteLine(sDelete + " was deleted from the dictionary");
                                    b3 = true;
                                }
                                catch (Exception delete)
                                {
                                    Console.WriteLine("That entry was not found in the dictionary");
                                }
                            }

                            else if (iChoice == 5)
                            {
                                //clear dictionary
                                Dictionary.Clear();
                                Console.WriteLine("The dictionary has been cleared");
                            }
                            else if (iChoice == 6)
                            { //search dictionary
                                string sSearch;
                                Console.WriteLine("What is the name of the item that you would like to search for?");
                                sSearch = Console.ReadLine();
                                Console.WriteLine();

                                if (Dictionary.ContainsKey(sSearch))
                                {
                                    Console.WriteLine("Name: " + sSearch + " Value: " + Dictionary[sSearch]); 
                                }
                                else
                                {
                                    Console.WriteLine(sSearch + " was not found in dictionary");
                                }
                                    
                            }
                            else
                            {
                                Console.WriteLine("please enter in a number from the menu");
                            }
                        } while (iChoice != 7);
                        
                        break;
                }

            } while (iDecision != 4);

        }
    }
}
