using com.app.businesstier.Contracts;
using com.app.models;
using System.Web.Http;

namespace com.app.hms.Controllers
{
    public class DelegateController : ApiController
    {
        private IDelegateLogic _delegateLogic;

        public DelegateController(IDelegateLogic delegateLogic)
        {
            _delegateLogic = delegateLogic;
        }

        [HttpPost]
        public bool Add(DelegateInfoEntity delegateInfoEntity)
        {
            return _delegateLogic.AddDelegateInfo(delegateInfoEntity);
        }
    }
}
