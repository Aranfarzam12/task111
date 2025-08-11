using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using task1.models;


namespace task1
{
    public class datacontext:DbContext
    {
        public datacontext(DbContextOptions<datacontext> options) : base(options)
        {
           
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
