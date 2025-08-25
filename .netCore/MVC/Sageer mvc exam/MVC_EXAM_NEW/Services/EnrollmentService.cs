using AutoMapper;
using MVC_EXAM_NEW.DTO;
using MVC_EXAM_NEW.Interfaces;

namespace MVC_EXAM_NEW.Services
{
    public class EnrollmentService:IEnrollmentService
    {
        private readonly IEnrollmentRepository _repository;
        public readonly IMapper _mapper;

        public EnrollmentService(IEnrollmentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<CourseDto> > GetEnrollmentCoursesAsync(int userId)
        {
            var enroll=await _repository.GetByUserIdAsync(userId);
            return _mapper.Map<IEnumerable<CourseDto>>(enroll);
        }
        public async Task EnrollAsync(int userId, int CourseId)
        {
            var enrol=await _repository.GetByUserAnsCourseAsync(userId,CourseId);
            if (enrol == null)
            {
                var enrollment=new enrollment { userId=userId,CourseId=CourseId};
                await _repository.AddAsync(enrollment);
            }
        }
        public async Task DropAsync(int userId, int courseId)
        {
            var enrol=await _repository.GetByUserAnsCourseAsync(userId,courseId);
            if(enrol == null)
            {
                await _repository.DeleteAsync(enrol.id);
            }
        }
    }
}
