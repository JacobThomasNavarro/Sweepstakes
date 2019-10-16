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
        public Sweepstakes GetSweepstakes()
        {
            return theSweepstakes.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            theSweepstakes.Enqueue(sweepstakes);
        }
    }
}
