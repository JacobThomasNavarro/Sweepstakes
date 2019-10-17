using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> theSweepstakes = new Queue<Sweepstakes>();
        Sweepstakes name;
        public Sweepstakes GetSweepstakes()
        {
            name = theSweepstakes.Dequeue();
            return name;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            theSweepstakes.Enqueue(sweepstakes);
            Console.WriteLine("Sweepstake has been added!");
            GetSweepstakes();
        }
    }
}
