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



            do
            {//do while 
                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit");

                iDecision = Convert.ToInt32(Console.ReadLine());

                switch (iDecision)
                {
                    case 1: //Logic for Stack

                        //variables for stack options!
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

                            switch (iMenu)
                            {
                                case 1:
                                    Console.WriteLine(); //blank line
                                    Console.Write("Enter one item into stack:");
                                    myStack.Push(Console.ReadLine());

                                    break;
                                case 2:

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
                                case 3:

                                    Console.WriteLine(); //blank line
                                    foreach (string sDisplay in myStack)
                                    {
                                        Console.WriteLine(sDisplay); //writing each item in Stack
                                    }

                                    break;
                                case 4:

                                    string iDelete;
                                    Console.WriteLine(); //blank line
                                    Console.WriteLine("Enter item you want to delete: ");
                                    Console.Write("New Entry #");

                                    iDelete = sEntry + Convert.ToString(Console.ReadLine());

                                    while (myStack.Count > 0)
                                    {

                                        //Remove iDelete from the stack
                                        if (myStack.Peek() == iDelete)
                                        {
                                            myStack.Pop();
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

                                    Console.WriteLine(iDelete + " Has been deleted");

                                    break;
                                case 5:

                                    Console.WriteLine();  //blank line
                                    //for loop clears all of stack
                                    for (int iCount = 0; myStack.Count > 0; iCount++)
                                    {
                                        myStack.Pop(); //deletes items
                                    }

                                    Console.WriteLine("List has been cleared.");

                                    break;
                                case 6:

                                    string iSearch;
                                    Console.WriteLine(); //blank line
                                    Console.WriteLine("Enter item you want to Search for: ");
                                    Console.Write("New Entry #");

                                    iSearch = sEntry + Convert.ToString(Console.ReadLine());

                                    while (myStack.Count > 0)
                                    {

                                        //searches for entry
                                        if (myStack.Peek() == iSearch)
                                        {
                                            Console.WriteLine(); //blank line
                                            Console.WriteLine(myStack.Peek());
                                        }
                                        else
                                        {
                                            //if it is not iDelete then push it to a new stack
                                            myHoldStack.Push(myStack.Pop());
                                        }
                                    }


                                    break;
                                case 7:

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



                        break;
                }

            } while (iDecision != 4);

        }
    }
}
