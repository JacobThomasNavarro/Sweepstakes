using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager sweepstakesStorageManager;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            sweepstakesStorageManager = sweepstakesManager;
        }
        public string CreateSweepstakes()
        {
            // prompt user for name
            Sweepstakes sweepstakes = new Sweepstakes("");
        }
        public void AddSweepstakes(Sweepstakes sweepstake)
        {
            sweepstakesStorageManager.InsertSweepstakes(sweepstake);
        }
    }
}
