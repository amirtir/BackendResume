using BackendResume.Enums;

namespace BackendResume.Dtos.Company
{
    public class CompanyGetDTO
    {
        public string Name { get; set; }
        public CompanySize Size { get; set; }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
