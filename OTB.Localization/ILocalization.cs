using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTB.Localization
{
    public interface ILocalization
    {
        string GetMessage(string resourceFile, string resourceName, string culture = null);

        string GetLabel(string resourceFile, string resourceName, string culture = null);
    }
}
