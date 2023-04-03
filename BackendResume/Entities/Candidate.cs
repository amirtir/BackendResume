namespace BackendResume.Entities
{
    public class Candidate :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastBame { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CoverLetter { get; set; }
        public string ResumeUrl { get; set; }
       
        //Relations

        public Job Job { get; set; }
        public int jobId { get; set; }
    }
}
