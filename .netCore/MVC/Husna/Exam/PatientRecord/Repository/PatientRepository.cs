using PatientRecord.Interface;
using PatientRecord.Models;
using Microsoft.EntityFrameworkCore;
namespace PatientRecord.Repository
{
    public class PatientRepository:IPatientRepository
    {
        private readonly AppDbContext _context;

        public PatientRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return await _context.patients.ToListAsync();
        }

        public async Task<Patient?> GetPatientByIdAsync(int id)
        {
            return await _context.patients.FindAsync(id);
        }

        public async Task AddPatientAsync(Patient patient)
        {
            _context.patients.Add(patient);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            _context.patients.Update(patient);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePatientAsync(int id)
        {
            var patient = await _context.patients.FindAsync(id);
            if (patient != null)
            {
                _context.patients.Remove(patient);
                await _context.SaveChangesAsync();
            }
        }
    }
}
