using com.app.gateway.Contracts;
using com.app.models;

namespace com.app.businesstier
{
    public class DelegateLogic : Contracts.IDelegateLogic
    {
        private IGateway<DelegateInfo> _delegateInfoGateway;
        public DelegateLogic(IGateway<DelegateInfo> delegateInfoGateway)
        {
            _delegateInfoGateway = delegateInfoGateway;
        }

        public bool AddDelegateInfo(DelegateInfoEntity delegateInfoEntity)
        {
            var delegateInfo = new DelegateInfo
            {
                FirstName = delegateInfoEntity.FirstName,
                LastName = delegateInfoEntity.LastName
            };
            var newDelegate = _delegateInfoGateway.Add(delegateInfo);
            _delegateInfoGateway.SaveChangesAsync();
            return true;
        }
    }
}
