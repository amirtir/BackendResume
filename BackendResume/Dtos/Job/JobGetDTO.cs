using BackendResume.Entities;
using BackendResume.Enums;

namespace BackendResume.Dtos.Job
{
    public class JobGetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public JobLevel jobLevel { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public List<Candidate> candidates { get; set; }

    }
}
