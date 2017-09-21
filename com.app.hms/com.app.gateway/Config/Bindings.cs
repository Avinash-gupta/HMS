using com.app.gateway.Contracts;
using com.app.gateway.Gateway;
using com.app.models;
using com.app.models.Context;
using Ninject.Modules;

namespace com.app.gateway
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IGateway<DelegateInfo>>().To<Gateway<HMSContext, DelegateInfo>>();
            Bind<IGateway<PatientInfo>>().To<Gateway<HMSContext, PatientInfo>>();
            Bind(typeof(IUnitOfWork<HMSContext>)).To(typeof(UnitOfWork<HMSContext>));
        }
    }
}
