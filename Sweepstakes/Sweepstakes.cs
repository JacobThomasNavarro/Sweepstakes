using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public List<Contestant> contestants;
        public Sweepstakes()
        {
            contestants = new List<Contestant>();
        }
        public void RunSweepstakes() //master method
        {
            for(int i = 0; i < 10; i++)
            {
                AddContestant();
            }
        }
        public void AddContestant()
        {
            Console.WriteLine("Enter contestant's first name.");
            string nameFirst = Console.ReadLine();

            Console.WriteLine("Enter contestant's last name.");
            string nameLast = Console.ReadLine();

            Console.WriteLine("Enter contestant's email address.");
            string email = Console.ReadLine();

            Console.WriteLine("Enter contestant's registration number.");
            int registration = Int32.Parse(Console.ReadLine());

            Contestant newContestant = new Contestant(nameFirst, nameLast, email, registration);
            contestants.Add(newContestant);
        }
    }
}
