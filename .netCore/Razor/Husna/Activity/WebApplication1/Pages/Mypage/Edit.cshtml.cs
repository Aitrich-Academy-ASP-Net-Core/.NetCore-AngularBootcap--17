using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using WebApplication1.Interface;
using WebApplication1.Model;
using WebApplication1.StudentDto;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.Mypage
{
    public class EditModel : PageModel
    {
        private readonly IStudentService _service;
        private readonly IMapper _mapper;

        public EditModel(IStudentService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [BindProperty]
        public StudDto StudDto { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var student = await _service.GetAllStudentAsync();
            var data = student.FirstOrDefault(s => s.Id == id);

            if (data == null)
            {
                return NotFound();
            }
            StudDto = _mapper.Map<StudDto>(data);
            StudDto.Id = data.Id; // Add Id to DTO if not already present
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await _service.UpdateStudentAsync(StudDto);
            return RedirectToPage("Index");
        }

    }
}
