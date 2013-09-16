using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using MvcUnityBootstrapperTest.Business;

namespace Microsoft.Practices.Unity
{
    public static partial class WithLifetime
    {
        public static LifetimeManager PerRequest(Type type)
        {
            return new PerRequestLifetimeManager();
        }
    }
}

