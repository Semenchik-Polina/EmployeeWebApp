using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using EmployeeBLL.Interfaces;
using EmployeeBLL.Services;

namespace EmployeeWebApp.Utils
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel _kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            _kernel = kernelParam;
            AddBindings();
        }


        private void AddBindings()
        {
            _kernel.Bind<IEmployeeService>().To<EmployeeService>();
            _kernel.Bind<ICandidateService>().To<CandidateService>();
        }


        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }


        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}