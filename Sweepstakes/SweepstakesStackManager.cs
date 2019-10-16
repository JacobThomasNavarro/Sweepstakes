using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> theSweepstakes = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            return theSweepstakes.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            theSweepstakes.Push(sweepstakes);
        }
    }
}
