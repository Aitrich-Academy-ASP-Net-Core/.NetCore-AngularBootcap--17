using PatientRecord.Dto;

namespace PatientRecord.Interface
{
    public interface IPatientService
    {
        Task<IEnumerable<PatientDto>> GetAllPatientsAsync();
        Task <PatientDto?>GetPatientByIdAsync(int id);
        Task AddPatientAsync(PatientDto patientDto);
        Task UpdatePatientAsync(PatientDto patientDto);
        Task DeletePatientAsync(int id);

    }
}
