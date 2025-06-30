using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Models
{
    public class SongContext:DbContext
    {


        //attaching connection string to songcontext class
        public SongContext( DbContextOptions<SongContext> dc)
            : base(dc)  
        {

        }
        //default path is compact edition
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // to set the db path 
        //    optionsBuilder.UseSqlServer("Data Source=WKSBAN36SUHTR04\\SQLEXPRESS;Initial Catalog=songdb;Integrated Security=True;Encrypt=False");
        //}

        public DbSet<Song> Songs { get; set; }
    }
}
