using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OTB.Localization
{
    public abstract class BaseLocalization<T> : ILocalization where T : BaseLocalization<T>, new()
    {
        private static ILocalization initialize = new T();

        private IDictionary<string, string> resources;

        public BaseLocalization()
        {
            resources = Resources();
        }

        public abstract IDictionary<string, string> Resources();

        public static ILocalization Initialize
        {
            get
            {
                return initialize;
            }
        }
        
        public virtual string GetLabel(string resourceFile, string resourceName, string cultureName = null)
        {
            cultureName = cultureName.IsNotNullOrEmpty()?cultureName: Thread.CurrentThread.CurrentCulture.CompareInfo.Name;
            
            var assembly = Assembly.Load(typeof(T).Assembly.GetName());

            var resourceNamespace = resources[resourceFile];

            resourceNamespace = string.Format("{0}.{1}_{2}", resourceNamespace,resourceFile, cultureName);

            ResourceManager rm = new ResourceManager(resourceNamespace,
                              assembly);

            return rm.GetString(resourceName);
        }

        public virtual string GetMessage(string resourceFile, string resourceName, string culture = null)
        {
            throw new NotImplementedException();
        }
    }
}
