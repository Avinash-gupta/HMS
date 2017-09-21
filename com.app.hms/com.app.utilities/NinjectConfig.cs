using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.app.utilities
{
    public static class NinjectConfig
    {
        public static StandardKernel Kernel { get; private set; }
        public static StandardKernel IocConfig()
        {
            var kernel = new StandardKernel();
            kernel.Load("com.app.businesstier.dll");
            kernel.Load("com.app.gateway.dll");
            Kernel = kernel;
            return kernel;
        }
    }
}
