using com.app.businesstier.Contracts;
using Ninject.Modules;

namespace com.app.businesstier.Config
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IDelegateLogic>().To<DelegateLogic>();
            Bind<IPatientLogic>().To<PatientLogic>();
        }
    }
}
