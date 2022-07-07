using BookLibrary.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DBOperations
{
    // **** INTERFACE **** from DbContext is required for EntityFramework in order to create a database
    public class BookLibraryDbContext : DbContext
    {
        //These are 3 tables that has been set.
        // Each tables are generated from  classes which are inherited from Abstract class
        public DbSet<Story> Stories { get; set; }
        public DbSet<Novel> Novels { get; set; }
        public DbSet<PersonalGrowth> PersonalGrowths { get; set; }


        //Database creation step
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "BookLibraryDatabase");
        }
    }
}
