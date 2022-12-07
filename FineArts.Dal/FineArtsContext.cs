using FineArts.Entities;
using Microsoft.EntityFrameworkCore;

namespace FineArts.Dal
{
    public class FineArtsContext : DbContext
    {
        public DbSet<Teacher> Teachers => Set<Teacher>(); //{ get; set; }
        public DbSet<Student> Students => Set<Student>(); 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string 
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=FineArts;");  
        }
    }
}