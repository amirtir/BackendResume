using AutoMapper;
using BackendResume.Dtos;
using BackendResume.Dtos.Company;
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
           

            //Job


            //Candidate
        }

    }
}
