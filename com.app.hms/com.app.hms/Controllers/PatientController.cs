using com.app.businesstier.Contracts;
using com.app.models;
using System.Web.Http;

namespace com.app.hms.Controllers
{
    public class PatientController : ApiController
    {
        private IPatientLogic _patientLogic;
        public PatientController(IPatientLogic patientLogic)
        {
            _patientLogic = patientLogic;
        }

        [HttpPost]
        [ActionName("Add")]
        public int Add(PatientInfoEntity patientInfoEntity)
        {
           return _patientLogic.AddPatient(patientInfoEntity);
        }

        [HttpPost]
        [ActionName("Update")]
        public bool Update(PatientInfoEntity patientInfoEntity)
        {
            return _patientLogic.UpdatePatient(patientInfoEntity);
        }

        [HttpGet]
        [ActionName("Get")]
        public PatientInfoEntity Get(int id)
        {
            return _patientLogic.GetPatient(id);
        }
    }
}
