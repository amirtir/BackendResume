using BackendResume.Enums;

namespace BackendResume.Entities
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public CompanySize  Size { get; set; }
        
        //Relations

        public List<Job> Jobs { get; set; }
        
    }
}
