using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace APSPService
{
    /// <summary>
    /// Class to implement a Custom Query Service Host Factory.
    /// This class inherit from <see cref="ServiceHostFactory"/>
    /// </summary>
    public class QueryServiceHostFactory: ServiceHostFactory
    {
        private static readonly ServiceProxyFactory ServiceProxyFactory = new ServiceProxyFactory();

        /// <summary>
        /// Method to create the ServiceHost to use 
        /// </summary>
        /// <param name="serviceType">The Service Type</param>
        /// <param name="baseAddresses">Service Addresses</param>
        /// <returns></returns>
        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            Type serviceProxyType = ServiceProxyFactory.GetProxyType(serviceType, () => new QueryService());
            return base.CreateServiceHost(serviceProxyType, baseAddresses);
        }
    }
}