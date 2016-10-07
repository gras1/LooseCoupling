using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAndSoftwareCraftmanship.DesignPrinciples.LowCoupling
{
    public class ConnectionPool
    {
        //http://stackoverflow.com/questions/3085285/cohesion-coupling

        private List<Connection> _freeConnectionList;
        private List<Connection> _inUseConnectionList;
        private List<IConnectionListener> _listeners;

        public Connection GetConnection
        {
            get
            {
                return new Connection();
            }
        }

        public void ReleaseConnection(Connection c)
        {
            //do something
        }

        public void RegisterListener(IConnectionListener l)
        {
            //do something
        }

        public void RemoveListener(IConnectionListener l)
        {
            //do something
        }
    }
}
