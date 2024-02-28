using Project_ClassLibrary_DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ClassLibrary_DAL
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext() : base("name = Blog")
        {

        }
        public DbSet<AdminInfo> AdminInfo { get; set; }
        public DbSet<EmpInfo> EmpInfo { get; set; }
        public DbSet<BlogInfo> BlogInfo { get; set; }
    }

}
