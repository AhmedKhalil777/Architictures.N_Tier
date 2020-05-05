using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using NTier.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTier.DAL
{
    public class  NTierDbContext : DbContext
    {
        public NTierDbContext(DbContextOptions<NTierDbContext> options): base(options) {}

        public DbSet<Table1> Table1s { get; set; }
        public DbSet<Table2> Table2s { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }




        }

    public class NTierContextFactory : IDesignTimeDbContextFactory<NTierDbContext>
    {
        public NTierDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<NTierDbContext>();
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=NTier;Trusted_Connection=true;MultipleActiveResultSets=true");

            return new NTierDbContext(optionsBuilder.Options);
        }
    }
}
