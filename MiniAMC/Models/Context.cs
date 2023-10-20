using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAMC.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                   .AddJsonFile("appsettings.json")
                   .Build();

            string connectionString = configuration["ConnectionStrings:DbConnectionString"];

            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Appraisal> Appraisal { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
