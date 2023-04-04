using BackendResume.Enums;

namespace BackendResume.Dtos.Job
{
    public class JobCreateDTO
    {
        public string Name { get; set; }
        public JobLevel jobLevel { get; set; }
        public int CompanyId { get; set; }


    }
}
