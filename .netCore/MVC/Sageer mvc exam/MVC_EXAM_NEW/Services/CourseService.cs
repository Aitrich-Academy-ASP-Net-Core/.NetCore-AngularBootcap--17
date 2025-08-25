using AutoMapper;
using MVC_EXAM_NEW.DTO;
using MVC_EXAM_NEW.Interfaces;
using MVC_EXAM_NEW.Models;

namespace MVC_EXAM_NEW.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _repository;
        public readonly IMapper _mapper;

        public CourseService(ICourseRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        async Task<IEnumerable<CourseDto>> GetAllAsync()
        {
            var course=await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<CourseDto>>(course);
        }
        public async Task<CourseDto> GetByIdAsync(int id)
        {
            var course=await _repository.GetByIdAsync(id);
            return _mapper.Map<CourseDto>(course);
        }
        public async Task AddAsync(CourseDto courseDto)
        {
            var course = _mapper.Map<Course>(courseDto);
            await _repository.AddAsync(course);
        }
        public async Task UpdateAsync(CourseDto courseDto)
        {
            var course = _mapper.Map<Course>(courseDto);
            await _repository.UpdateAsync(course);
        }
        public async Task DeteleAsync(int id)
        {
            
            await _repository.DeleteAsync(id);
        }
    }
}