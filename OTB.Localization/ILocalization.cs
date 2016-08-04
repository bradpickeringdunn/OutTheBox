using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTB.Localization
{
    public interface ILocalization
    {
        ILocalization Initialize { get; }

        string GetMessage(string resource);

        string GetLabel(string resource);
    }
}
