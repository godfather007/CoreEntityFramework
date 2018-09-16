using Microsoft.EntityFrameworkCore;

namespace CoreEntityFramework.Models
{
    public class MvcEmployeeContext : DbContext
    {
        public MvcEmployeeContext (DbContextOptions<MvcEmployeeContext> options)  
            : base(options)  
        {  
        }  
  
        public DbSet<CoreEntityFramework.Models.Employee> Employees { get; set; }  

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(@"Server=.\;Database=dotNetCore;Trusted_Connection=True;MultipleActiveResultSets=true");
        // }
    }
}