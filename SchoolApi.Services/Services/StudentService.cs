using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolApi.Data.Transactions;
using SchoolApi.Domain.DTO.Student;
using SchoolApi.Services.Interfaces;

namespace SchoolApi.Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUow _uow;

        public StudentService(IUow uow)
        {
            _uow = uow;
        }

        public Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IEnumerable<StudentDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async ValueTask<StudentDto> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<CreateStudentResultDto> Post(CreateStudentDto student)
        {
            throw new NotImplementedException();
        }

        public Task<UpdateStudentResultDto> Put(UpdateStudentDto student)
        {
            throw new NotImplementedException();
        }
    }
}