using NFW.Controller;
using System;

namespace NFW
{
    public class NfwController : IDisposable
    {
        private NfwWindowController m_winController;
        private StateController m_stateController;
        private string m_clientVersion;

        public NfwController(string versionOfclient)
        {
            m_clientVersion = versionOfclient;

            m_winController = new NfwWindowController();
            m_stateController = new StateController(m_clientVersion);
        }

        public bool IsDisplayRequired(string id)
        {
            return m_stateController.IsDisplayRequired(id);
        }

        public bool CreatePage(string header, string text, Uri imgUri)
        {
            return m_winController.AddPage(header, text, imgUri);
        }

        public void Dispose()
        {
            m_winController.Close();
        }
    }
}
