using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSoftwareCraftmanship.DesignPrinciples.LowCoupling
{
    public class PersistentStore : IConnectionListener
    {
        public void ConnectionRequested(Connection c)
        {
            //do something
        }

        public void ConnectionReleased(Connection c)
        {
            //do something
        }
    }
}
