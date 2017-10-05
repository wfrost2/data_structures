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

                        Queue<string> userQueue = new Queue<string>();  //Create data structure: queue for this option
                        int QResponse = 0;

                        while (QResponse != 7)
                        {
                            Console.WriteLine("\nChoose a number:\n" +        //Menu for queue option
                                "1. Add one time to Queue\n" +
                                "2. Add Huge List of Items to Queue\n" +
                                "3. Display Queue\n" +
                                "4. Delete from Queue\n" +
                                "5. Clear Queue\n" +
                                "6. Search Queue\n" +
                                "7. Return to Main Menu");

                            int.TryParse(Console.ReadLine(), out QResponse);  //read users response 

                            if (QResponse == 1)
                            {
                                Console.WriteLine("\nGo ahead and add something to the queue!");
                                userQueue.Enqueue(Console.ReadLine());  //add their input to the queue
                                Console.WriteLine("");
                            }
                            else if (QResponse == 2)
                            {
                                userQueue.Clear(); //clear the queue

                                for (int iCount = 0; iCount < 2000; iCount++) //add entries up to 2000
                                {
                                    userQueue.Enqueue("New Entry " + (iCount + 1));
                                }
                                Console.WriteLine("List Created.\n");
                            }
                            else if (QResponse == 3)
                            {
                                Console.WriteLine("");
                                foreach (string entry in userQueue) //use for each to display every entry
                                {
                                    Console.WriteLine(entry);
                                }
                                Console.WriteLine("");
                            }
                            else if (QResponse == 4)
                            {
                                int QSize = userQueue.Count; //get initial size of queue

                                Console.WriteLine("\nThere are " + userQueue.Count + " things in the queue. Which one do you want to delete?");
                                int userDeleteOption = (int.Parse(Console.ReadLine()) - 1); //user puts in one they want to delete

                                int iCount;
                                Queue<string> tempQueue = new Queue<string>();  //create a temporary queue
                                for (iCount = 0; iCount < userDeleteOption; iCount++) //for the first part of queue (up to the index they want to delete)
                                {
                                    tempQueue.Enqueue(userQueue.Dequeue()); //take the first element and put it in the temporary queue
                                }

                                userQueue.Dequeue(); //throw away the one they selected

                                for (iCount = (userDeleteOption + 1); iCount < QSize; iCount++) //for the last part of the queue
                                {
                                    tempQueue.Enqueue(userQueue.Dequeue()); //take the element and put it in the temporary queue
                                }


                                userQueue.Clear(); //clear the first queue
                                for (int iCount1 = 0; iCount1 < (QSize - 1); iCount1++)
                                {
                                    userQueue.Enqueue(tempQueue.Dequeue()); //put everything in the temp queue back in the main queue
                                }
                                tempQueue.Clear(); //clean up after yourself
                                Console.WriteLine("");
                            }
                            else if (QResponse == 5)
                            {
                                userQueue.Clear(); //clear out the whole queue
                                Console.WriteLine("\nThe queue has been cleared out.\n");
                            }
                            else if (QResponse == 6)
                            {
                                int QLength = userQueue.Count;

                                Console.WriteLine("\nWhat would you like to search for in the queue?");
                                string userSearch = Console.ReadLine();

                                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); //create stopwatch object
                                sw.Start(); //start the stopwatch

                                Queue<string> tempQueue1 = new Queue<string>(); //create a temporary queue
                                bool foundIt = false;
                                bool completeSearch = false;

                                for (int iCount = 0; iCount < (QLength - 1); iCount++)
                                {
                                    if (completeSearch == false)
                                    {
                                        foundIt = userSearch.Equals(userQueue.Peek(), StringComparison.InvariantCultureIgnoreCase); //boolean if we found the string


                                        if (foundIt == true)
                                        {
                                            sw.Stop(); //stop the stopwatch
                                            Console.WriteLine("\nYour search was found! It took " + sw.Elapsed + " milliseconds to find your result.\n");
                                            for (int iCount1 = iCount; iCount1 < (userQueue.Count - 1); iCount1++) //finish clearing the queue into the temporary queue
                                            {
                                                tempQueue1.Enqueue(userQueue.Dequeue()); //take the element and put it in the temporary queue
                                                iCount = iCount1; //match those up, so you can get out of the big for loop
                                            }
                                            completeSearch = true;
                                        }
                                    }

                                    tempQueue1.Enqueue(userQueue.Dequeue()); //take the element and put it in the temporary queue
                                }
                                if (foundIt == false)
                                {
                                    Console.WriteLine("\nYour search was not found.\n");
                                }

                                userQueue.Clear(); //clear the first queue
                                for (int iCount1 = 0; iCount1 < (QLength - 1); iCount1++)
                                {
                                    userQueue.Enqueue(tempQueue1.Dequeue()); //put everything in the temp queue back in the main queue
                                }
                                tempQueue1.Clear(); //clean up after yourself
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("Enter a number 1-7");
                            }
                        }


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
                                Dictionary.Clear();

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

            //queue at bottom
        }
    }
}
