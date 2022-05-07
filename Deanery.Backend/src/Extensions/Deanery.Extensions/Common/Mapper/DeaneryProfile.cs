using AutoMapper;
using Deanery.Domain.Entities;
using Deanery.Domain.Models.Request;

namespace Deanery.Extensions.Common.Mapper
{
    public class DeaneryProfile : Profile
    {
        public DeaneryProfile()
        {
            CreateMap<CreateSubjectRequest, Subject>().ReverseMap();
            CreateMap<CreateTeacherRequest, Teacher>().ReverseMap();
            CreateMap<CreateScheduleRequest, Schedule>().ReverseMap();
            CreateMap<CreateStudentRequest, Student>().ReverseMap();
            CreateMap<CreateGroupRequest, Group>().ReverseMap();
        }
    }
}
