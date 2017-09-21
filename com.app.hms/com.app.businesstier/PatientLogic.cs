using com.app.businesstier.Contracts;
using com.app.gateway.Contracts;
using com.app.models;
using System.Linq;

namespace com.app.businesstier
{
    public class PatientLogic : IPatientLogic
    {
        private IGateway<PatientInfo> _patientInfoGateway;

        public PatientLogic(IGateway<PatientInfo> patientInfoGateway)
        {
            _patientInfoGateway = patientInfoGateway;
        }

        public int AddPatient(PatientInfoEntity patientInfoEntity)
        {
            var newId = _patientInfoGateway.GetAll().ToList().Count + 1;
            var _patientInfo = new PatientInfo
            {
                Id = newId,
                FirstName = patientInfoEntity.FirstName,
                LastName = patientInfoEntity.LastName,
                PhoneNo = patientInfoEntity.PhoneNo,
                Email = patientInfoEntity.Email,
                Address = patientInfoEntity.Address,
                City = patientInfoEntity.City,
                State = patientInfoEntity.State,
                Age = patientInfoEntity.Age,
                DateOfBirth = patientInfoEntity.DateOfBirth,
                Gender = patientInfoEntity.Gender,
                Pincode = patientInfoEntity.Pincode,
                Type = patientInfoEntity.Type,
                Symptoms = patientInfoEntity.Symptoms,
                Description = patientInfoEntity.Description,
                LineOne = patientInfoEntity.LineOne,
                LineTwo = patientInfoEntity.LineTwo,
                LineThree = patientInfoEntity.LineThree,
            };
            _patientInfoGateway.Add(_patientInfo);
            _patientInfoGateway.SaveChangesAsync();
            return newId;
        }

        public bool UpdatePatient(PatientInfoEntity patientInfoEntity)
        {
            var _patientInfo = new PatientInfo
            {
                Id = patientInfoEntity.Id,
                FirstName = patientInfoEntity.FirstName,
                LastName = patientInfoEntity.LastName,
                PhoneNo = patientInfoEntity.PhoneNo,
                Email = patientInfoEntity.Email,
                Address = patientInfoEntity.Address,
                City = patientInfoEntity.City,
                State = patientInfoEntity.State,
                Age = patientInfoEntity.Age,
                DateOfBirth = patientInfoEntity.DateOfBirth,
                Gender = patientInfoEntity.Gender,
                Pincode = patientInfoEntity.Pincode,
                Type = patientInfoEntity.Type,
                Symptoms = patientInfoEntity.Symptoms,
                Description = patientInfoEntity.Description,
                LineOne = patientInfoEntity.LineOne,
                LineTwo = patientInfoEntity.LineTwo,
                LineThree = patientInfoEntity.LineThree,
            };
            _patientInfoGateway.Update(_patientInfo);
            _patientInfoGateway.SaveChangesAsync();
            return true;
        }

        public PatientInfoEntity GetPatient(int id)
        {
            var _patientInfo = _patientInfoGateway.GetByIdAsync(id).Result;
            var _patientInfoEntity = new PatientInfoEntity
            {
                Id = _patientInfo.Id,
                FirstName = _patientInfo.FirstName,
                LastName = _patientInfo.LastName,
                PhoneNo = _patientInfo.PhoneNo,
                Email = _patientInfo.Email,
                Address = _patientInfo.Address,
                City = _patientInfo.City,
                State = _patientInfo.State,
                Age = _patientInfo.Age,
                DateOfBirth = _patientInfo.DateOfBirth,
                Gender = _patientInfo.Gender,
                Pincode = _patientInfo.Pincode,
                Type = _patientInfo.Type,
                Symptoms = _patientInfo.Symptoms,
                Description = _patientInfo.Description,
                LineOne = _patientInfo.LineOne,
                LineTwo = _patientInfo.LineTwo,
                LineThree = _patientInfo.LineThree,
            };
            return _patientInfoEntity;
        }
    }
}
