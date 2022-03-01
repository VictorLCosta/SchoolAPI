using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolApi.Domain.DTO.Student;

namespace SchoolApi.Services.Interfaces
{
    public interface IStudentService
    {
        ValueTask<StudentDto> GetById(Guid id);
        ValueTask<IEnumerable<StudentDto>> GetAll();

        Task<CreateStudentResultDto> Post(CreateStudentDto student);
        Task<UpdateStudentResultDto> Put(UpdateStudentDto student);
        Task<bool> Delete(Guid id);
    }
}