using STUDENTINFOMATION.Model;
using STUDENTINFOMATION.Userdto;

namespace STUDENTINFOMATION.Interface
{
    public interface IStudentRepository
    {

        public Task<List<Student>> GetAllStudentAsync();
        public Task AddStudentAsync(Studentdto studentdto);
        public Task UpdateStudentAsync(Studentdto studentdto);

    }
}
