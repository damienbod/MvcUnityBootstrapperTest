using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcUnityBootstrapperTest.Logging;

namespace MvcUnityBootstrapperTest.Business
{
    public class UnitOfWorkExample : IUnitOfWorkExample
    {
        public UnitOfWorkExample()
        {
            UnityEventLogger.Log.CreateUnityMessage("UnitOfWorkExample");
        }

        private bool _disposed = false;

        public void Dispose()
        {
            UnityEventLogger.Log.DisposeUnityMessage("UnitOfWorkExample");
            if (!_disposed)
            {
                _disposed = true;
            }
        }

        public string HelloFromUnitOfWorkExample()
        {
            UnityEventLogger.Log.LogUnityMessage("Hello UnitOfWorkExample");
            return "HelloFromUnitOfWorkExample";
        }
    }
}