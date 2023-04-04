using AutoMapper;
using BackendResume.Context;
using BackendResume.Dtos.Job;
using BackendResume.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendResume.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private MyContext _context;
        private IMapper _mapper;

        public JobController(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        //CRUD


        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateJob([FromBody] JobCreateDTO dTO)
        {
            var job = _mapper.Map<Job>(dTO);
            await _context.jobs.AddAsync(job);
            await _context.SaveChangesAsync();

            return Ok("Job Created Successfully");
        }


        //Read

        [HttpGet]
        [Route("JobsList")]
        public async Task<ActionResult<IEnumerable<JobGetDTO>>> GetAllJobs()
        {
            var list= _context.jobs.Include(c=>c.company)
                .Include(g=>g.candidates)
                .ToList(); 

            var convertedlist= _mapper.Map<IEnumerable<JobGetDTO>>(list);


            return Ok(convertedlist);
        }




    }
}
