using System;
using SchoolApi.Domain.ValueObjects;

namespace SchoolApi.Domain.DTO.Student
{
    public class StudentDto
    {
        public Guid Id { get; set; }
        public string RA { get; set; }
        public Email Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string CPF { get; set; }
    }
}