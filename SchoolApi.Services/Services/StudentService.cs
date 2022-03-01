using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using SchoolApi.Data.Transactions;
using SchoolApi.Domain.DTO.Student;
using SchoolApi.Domain.Entities;
using SchoolApi.Services.Interfaces;

namespace SchoolApi.Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;

        public StudentService(IUow uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _uow.Students.RemoveAsync(id);
        }

        public async ValueTask<IEnumerable<StudentDto>> GetAll()
        {
            var students = await _uow.Students.GetAllAsync();
            
            return _mapper.Map<IEnumerable<StudentDto>>(students);
        }

        public async ValueTask<StudentDto> GetById(Guid id)
        {
            var student = await _uow.Students.GetByIdAsync(id);

            return _mapper.Map<StudentDto>(student);
        }

        public async Task<CreateStudentResultDto> Post(CreateStudentDto student)
        {
            var studentDb = _mapper.Map<Student>(student);

            return _mapper.Map<CreateStudentResultDto>(await _uow.Students.AddAsync(studentDb));
        }

        public async Task<UpdateStudentResultDto> Put(UpdateStudentDto student)
        {
            var studentDb = _mapper.Map<Student>(student);

            return _mapper.Map<UpdateStudentResultDto>(await _uow.Students.UpdateAsync(studentDb));
        }
    }
}