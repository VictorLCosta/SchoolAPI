using System;

namespace SchoolApi.Domain.DTO.Student
{
    public class UpdateStudentResultDto
    {
        public Guid Id { get; set; }
        public string RA { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string CPF { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}