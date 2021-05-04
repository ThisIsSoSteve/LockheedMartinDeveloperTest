using LockheedMartin.DeveloperTest.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LockheedMartin.DeveloperTest.DAL
{
    public class ForecastDbContext : DbContext
    {
        public ForecastDbContext(DbContextOptions<ForecastDbContext> options) : base(options)
        {
        }

        public virtual DbSet<ForecastWeek> ForecastWeeks { get; set; }
        public virtual DbSet<ForecastTemperature> ForecastTemperatures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new SeedData().SetExample(modelBuilder);
        }
    }
}
