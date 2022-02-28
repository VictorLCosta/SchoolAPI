using SchoolApi.Data.Interfaces;
using SchoolApi.Domain.Entities;

namespace SchoolApi.Data.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}