using AbbyCRUD.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyCRUD.Data
{
    public class AppDbConText: DbContext
    {
        public AppDbConText(DbContextOptions<AppDbConText>options) : base(options)
        {

        }
        //public DbSet<Modelname> Tablename { get; set; }  //get and set
        public DbSet<Category> Category { get; set; } 
    }
}
