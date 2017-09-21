using com.app.models;

namespace com.app.businesstier.Contracts
{
    public interface IPatientLogic
    {
        int AddPatient(PatientInfoEntity patientInfoEntity);
        PatientInfoEntity GetPatient(int Id);
        bool UpdatePatient(PatientInfoEntity patientInfoEntity);
    }
}
