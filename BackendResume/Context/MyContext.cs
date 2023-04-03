using BackendResume.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackendResume.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Company> companies { get; set; }
        public DbSet<Job> jobs { get; set; }
        public DbSet<Candidate> candidates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>().HasOne(job => job.company)
                .WithMany(company => company.Jobs)
                .HasForeignKey(job => job.CompanyId);

            modelBuilder.Entity<Candidate>().HasOne(candidate => candidate.Job)
                .WithMany(job => job.candidates)
                .HasForeignKey(candidate => candidate.jobId);

            modelBuilder.Entity<Company>()
                .Property(company => company.Size)
                .HasConversion<string>();

            modelBuilder.Entity<Job>()
               .Property(job => job.jobLevel)
               .HasConversion<string>();
        }

    }
}
