using Microsoft.EntityFrameworkCore;
using sms.Models;

namespace sms.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    public DbSet<Student> Students {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasData(
            new Student{Id = 100, Name = "Athanas Shauritanga", Phone = "+255655591660"},
            new Student{Id = 101, Name = "Salim Abu", Phone = "+255679983541"}
            );
    }
}
 