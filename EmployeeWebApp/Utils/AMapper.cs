using EmployeeBLL.DTO;
using EmployeeWebApp.Models;
using AutoMapper;


namespace EmployeeWebApp.Utils
{
    public class AMapper
    {
        public AMapper()
        {
            MapperConfiguration configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EmployeeGetDTO, EmployeeViewModel>()
                    .ForMember(vm => vm.FullName,
                        x => x.MapFrom(dto => dto.Person.FirstName + " " + dto.Person.LastName))
                    .ForMember(vm => vm.Email,
                        x => x.MapFrom(dto => dto.Person.Email))
                    .ForMember(vm => vm.PhoneNumber,
                        x => x.MapFrom(dto => dto.Person.PhoneNumber));

                cfg.CreateMap<CandidateGetDTO, CandidateViewModel>()
                    .ForMember(vm => vm.FullName,
                        x => x.MapFrom(dto => dto.Person.FirstName + " " + dto.Person.LastName))
                    .ForMember(vm => vm.Email,
                        x => x.MapFrom(dto => dto.Person.Email))
                    .ForMember(vm => vm.PhoneNumber,
                        x => x.MapFrom(dto => dto.Person.PhoneNumber));
            });
            Mapper = configuration.CreateMapper();
        }

        public IMapper Mapper { get; }
    }
}