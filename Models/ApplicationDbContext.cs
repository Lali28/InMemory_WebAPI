using Microsoft.EntityFrameworkCore;
using ProjectManagementAPI.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet for Projects (Add other DbSets if needed)
    public DbSet<Project> Projects { get; set; }
}
