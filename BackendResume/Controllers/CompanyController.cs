using AutoMapper;
using BackendResume.Context;
using BackendResume.Dtos;
using BackendResume.Dtos.Company;
using BackendResume.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendResume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        private MyContext _context;
        private IMapper _mapper;
        public CompanyController(MyContext myContext, IMapper mapper)
        {
            _context = myContext;
            _mapper = mapper;
        }

        //CRUD


        //Create

        [HttpPost]
        [Route("Create")]

        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDTO dto)
        {
            var company = _mapper.Map<Company>(dto);

            await _context.companies.AddAsync(company);
            await _context.SaveChangesAsync();

            return Ok("Company Created Successfuly");

        }
        //Read
        [HttpGet]
        [Route("CompaniesList")]
        public async Task< ActionResult<IEnumerable<CompanyGetDTO>>> GetallCompanies()
        {
           var companylist= _context.companies.ToList();
            var convertedlist= _mapper.Map<IEnumerable<CompanyGetDTO>>(companylist);
            return Ok(convertedlist);


        }


        //Update



        //Delete

    }
}
