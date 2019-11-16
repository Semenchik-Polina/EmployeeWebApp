using AutoMapper;
using EmployeeBLL.DTO;
using EmployeeDAL.Entities;

namespace EmployeeBLL.Utils
{
    public class AMapper
    {
        public AMapper()
        {
            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Employee, EmployeeGetDTO>();
                cfg.CreateMap<Candidate, CandidateGetDTO>();
                cfg.CreateMap<Person, PersonGetDTO>();
            });
            Mapper = configuration.CreateMapper();
        }

        public IMapper Mapper { get; }
    }
}
