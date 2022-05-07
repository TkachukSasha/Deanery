using AutoMapper;
using Deanery.Application.Common.Pagination.Filters;
using Deanery.Application.Common.Pagination.Queries;
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
            CreateMap<PaginationQuery, PaginationFilter>().ReverseMap();
        }
    }
}
