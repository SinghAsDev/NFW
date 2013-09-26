using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFW.Model
{
    internal class NfwPage
    {
        internal PageHeader Header { get; set; }
        internal PageBackground Background { get; set; }
        internal PageText Text { get; set; }

        public NfwPage(PageHeader header, PageBackground background, PageText text)
        {
            Header = header;
            Background = background;
            Text = text;
        }
    }
}
