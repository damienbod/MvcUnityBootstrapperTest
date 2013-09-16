﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcUnityBootstrapperTest.Logging;

namespace MvcUnityBootstrapperTest.Business
{
    public class BusinessClass : IBusinessClass
    {
        private IUnitOfWorkExample _unitOfWorkExample;

        public BusinessClass(IUnitOfWorkExample unitOfWorkExample)
        {
            _unitOfWorkExample = unitOfWorkExample;
            UnityEventLogger.Log.CreateUnityMessage("BusinessClass");
        }

        private bool _disposed = false;
        public string Hello()
        {
            UnityEventLogger.Log.LogUnityMessage("Hello BusinessClass");
            return "Hello from Business class";
        }

        public void Dispose()
        {
            UnityEventLogger.Log.DisposeUnityMessage("BusinessClass");
            if (!_disposed)
            {
                _disposed = true;
            }
        }
    }
}