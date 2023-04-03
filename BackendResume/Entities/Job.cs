using BackendResume.Enums;

namespace BackendResume.Entities
{
    public class Job :BaseEntity
    {
        public string Name { get; set; }
        public JobLevel  jobLevel { get; set; }

        //Relations

        public Company company { get; set; }
        public int  CompanyId { get; set; }

        public List<Candidate> candidates { get; set; }
    }
}
