using AutoMapper;
using SchoolApi.Domain.DTO.Student;
using SchoolApi.Domain.Entities;

namespace SchoolApi.CrossCutting.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>()
                .ReverseMap();

            CreateMap<CreateStudentDto, Student>()
                .ReverseMap();

            CreateMap<UpdateStudentDto, Student>()
                .ReverseMap();

            CreateMap<CreateStudentResultDto, Student>()
                .ReverseMap();

            CreateMap<UpdateStudentResultDto, Student>()
                .ReverseMap();
        }
    }
}