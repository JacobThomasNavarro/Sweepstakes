using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = UserInterface.GetSweepstakesManager();

            switch (choice)
            {
                case 1:
                    SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
                    MarketingFirm marketingFirm = new MarketingFirm(sweepstakesStackManager);
                    break;

                case 2:
                    SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
                    MarketingFirm marketingFirm2 = new MarketingFirm(sweepstakesQueueManager);
                    break;
            }
        }
    }
}
