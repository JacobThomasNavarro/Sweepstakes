using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public string sweepstakes1;
        public string sweepstakes2;
        public string sweepstakes3;
        List<string> sweepstakes;
        public MarketingFirm()
        {
            sweepstakes = new List<string>() { };
        }
        public void CreateSweepstakes()
        {
            Console.WriteLine("Add your first Sweepstake.");
            sweepstakes1 = Console.ReadLine();
            sweepstakes.Add(sweepstakes1);
            Console.WriteLine("Add your second Sweepstake.");
            sweepstakes2 = Console.ReadLine();
            sweepstakes.Add(sweepstakes2);
            Console.WriteLine("Add your third Sweepstake.");
            sweepstakes3 = Console.ReadLine();
            sweepstakes.Add(sweepstakes3);
        }
    }
}
