using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSoftwareCraftmanship.DesignPrinciples.LowCoupling
{
    public interface IConnectionListener
    {
        void ConnectionRequested(Connection c);
        void ConnectionReleased(Connection c);
    }
}
