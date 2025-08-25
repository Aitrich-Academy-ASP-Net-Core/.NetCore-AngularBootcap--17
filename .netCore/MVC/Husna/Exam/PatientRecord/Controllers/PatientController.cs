using Microsoft.AspNetCore.Mvc;
using PatientRecord.Dto;
using PatientRecord.Interface;
namespace PatientRecord.Controllers
{
    public class PatientController:Controller
    {
        private readonly IPatientService _patientService;
        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _patientService.GetAllPatientsAsync();
            return View(patients);
        }
        [HttpGet]
        public IActionResult Create()
        {
          
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(PatientDto patientDto)
        {
            if (!ModelState.IsValid)
                return View(patientDto);
            await _patientService.AddPatientAsync(patientDto);
            return RedirectToAction(nameof(GetAllPatients));
        }
        public async Task<IActionResult> Details(int id)
        {
            var patient = await _patientService.GetPatientByIdAsync(id);
            if (patient == null) return NotFound();
            return View(patient);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var patient = await _patientService.GetPatientByIdAsync(id);
            if (patient == null) return NotFound();
            return View(patient);
        }
        [HttpPost]
        public async Task<IActionResult>Edit(PatientDto patientDto)
        {
            if (!ModelState.IsValid)
                return View(patientDto);

            await _patientService.UpdatePatientAsync(patientDto);
            return RedirectToAction(nameof(GetAllPatients));
        }
        public async Task<IActionResult>Delete(int id)
        {
            var patient = await _patientService.GetPatientByIdAsync(id);
            if (patient == null) return NotFound();
            return View(patient);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _patientService.DeletePatientAsync(id);
            return RedirectToAction(nameof(GetAllPatients));
        }

    }
    
}
