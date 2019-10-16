using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakes = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakes.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            
        }
    }
}
