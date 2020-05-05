using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Sample.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.DAL
{
    public class  SampleDbContext : DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options): base(options) {}

        public DbSet<Table1> Table1s { get; set; }
        public DbSet<Table2> Table2s { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }




        }

    public class SampleContextFactory : IDesignTimeDbContextFactory<SampleDbContext>
    {
        public SampleDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SampleDbContext>();
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=Sample;Trusted_Connection=true;MultipleActiveResultSets=true");

            return new SampleDbContext(optionsBuilder.Options);
        }
    }
}
