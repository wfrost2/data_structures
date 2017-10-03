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
            do
            {//do while 
                Console.WriteLine("1. Stack");
                Console.WriteLine("2. Queue");
                Console.WriteLine("3. Dictionary");
                Console.WriteLine("4. Exit");

                iDecision = Convert.ToInt32(Console.ReadLine());

                switch(iDecision)
                {
                    case 1:
                        //Logic for Stack


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
