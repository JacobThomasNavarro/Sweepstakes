using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stuff = new Stack<Sweepstakes>();
        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            return stuff.Pop();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
