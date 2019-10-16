using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakes = new Queue<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            
        }
    }
}
