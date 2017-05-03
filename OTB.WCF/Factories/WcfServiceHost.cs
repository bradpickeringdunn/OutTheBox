using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using OTB.WCF.Factories;

namespace OTB.WCF.Factories
{
    public class WcfServiceHost : UnityServiceHost
    {
        public WcfServiceHost(IUnityContainer container, Type t, params Uri[] baseAdresses) :
            base(container, t, baseAdresses) { }
    }
}
