using CleanBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanBlog.Data
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions options):base(options)
        {}
        public DbSet<About> Abouts { get; set; }    
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }  
     
    }
}
