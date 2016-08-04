using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTB.Localization
{
    public class Localization : ILocalization
    {
        ILocalization initialize = null;

        public ILocalization Initialize
        {
            get
            {
                if (initialize.IsNull())
                {
                    initialize = new Localization();
                }

                return initialize;
            }
        }
        
        public string GetLabel(string resource)
        {
            throw new NotImplementedException();
        }

        public string GetMessage(string resource)
        {
            throw new NotImplementedException();
        }

    }
}
