using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_closed_principle
{
    class BoardComputer
    {
        public void PerformLanding(ILandingProfile landingProfile)
        {
            landingProfile.Execute();
        }
    }
}
