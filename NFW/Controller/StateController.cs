using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFW.Controller
{
    internal class StateController
    {
        private string m_clientVersion;
        static int m_chk = 0;

        public StateController(string clientVersion)
        {
            m_clientVersion = clientVersion;
        }

        internal bool IsDisplayRequired(string id)
        {
            return m_chk++ < 1 ? true : false;
        }
    }
}
