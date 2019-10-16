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
            CreateSweepstakes();
        }
        public void CreateSweepstakes()
        {
            string sweepstake = UserInterface.SweepstakeName();
            Sweepstakes sweepstakes = new Sweepstakes(sweepstake);
            sweepstakesStorageManager.InsertSweepstakes(sweepstakes);
        }
    }
}
