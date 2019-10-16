using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void ContestantInformation()
        {
            Console.WriteLine("Please enter the contestant's information.");
        }
        public static int GetSweepstakesManager()
        {
            Console.WriteLine("Select a Sweepstakes Manager to use.\n1)Sweepstakes Stack Manager\n2)Sweepstakes Queue Manager");
            int choice = Int32.Parse(Console.ReadLine());
            return choice;
        }
    }
}
