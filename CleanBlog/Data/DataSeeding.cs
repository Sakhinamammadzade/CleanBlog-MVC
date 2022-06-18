using CleanBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanBlog.Data
{
    public class DataSeeding
    {
        private readonly BlogDbContext _context;
        public DataSeeding(BlogDbContext context)
        {
            _context = context;
        }

        public void SeedData()
        {
            if (_context.Database.GetPendingMigrations().Count()==0)
            {
                if (_context.Abouts.Count() == 0)
                {
                    _context.Abouts.AddRange(About);
               
                     
                }
                if(_context.Abouts.Count() == 0)
                {
                    _context.Blogs.AddRange(Blogs);
                   
                }
                _context.SaveChanges();
            }
        }
        public About[] About =
        {
             new About(){
             Title="About Me",
             Description="This is what I do",
             PhotoURL="https://cdn.pixabay.com/photo/2017/08/10/08/47/laptop-2620118_1280.jpg", 
             CreatedDate=DateTime.Now,
             }
        };
        public Blog[] Blogs =
        {
            new Blog()
            {
                 Title="Basliq 1",
                 Description=" Code",
                 SubTitle="Basliq 1 ucun title",
                 PhotoUrl="https://media.istockphoto.com/photos/developing-programmer-reading-computer-codes-development-website-and-picture-id1164357236?b=1&k=20&m=1164357236&s=170667a&w=0&h=X8IlFUiJjKQdOwloeOJChA2bRmiq7JjCWUcoGisnCO0=",
                 CreatedDate=DateTime.Now,
            },
            new Blog()
            {
                 Title="Basliq 2",
                 Description="Code",
                 SubTitle="Basliq 2 ucunsubtitle",
                 PhotoUrl="https://cdn.pixabay.com/photo/2017/08/10/08/47/laptop-2620118__340.jpg",
                 CreatedDate=DateTime.Now,
            },
            new Blog()
            {
                 Title="Basliq 3",
                 Description="Code",
                 SubTitle="Basliq 3 ucun title",
                 PhotoUrl="https://cdn.pixabay.com/photo/2016/11/19/14/00/code-1839406__480.jpg",
                 CreatedDate=DateTime.Now,
            }

        };

       

        

    }
}
