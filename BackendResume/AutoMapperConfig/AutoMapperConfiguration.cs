using AutoMapper;
using BackendResume.Dtos.Company;
using BackendResume.Dtos.Job;
using BackendResume.Entities;

namespace BackendResume.AutoMapperConfig
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            //Company

            CreateMap<CompanyCreateDTO, Company>();
            CreateMap<Company, CompanyGetDTO > ();
           CreateMap<JobCreateDTO,Job>();


            CreateMap<Job, JobGetDTO>()
                .ForMember(des => des.CompanyName, opt => opt.MapFrom(src => src.company.Name));

            //Job


            //Candidate
        }

    }
}
