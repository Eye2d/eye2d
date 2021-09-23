using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eye2d.app_data.Entity_framwork
{
    public class Eye2dDb_ContextFactory : IDesignTimeDbContextFactory<Eye2d_DBcontext>
    {
        public Eye2d_DBcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("Eye2dDb");
            var optionsBuilder = new DbContextOptionsBuilder<Eye2d_DBcontext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new Eye2d_DBcontext(optionsBuilder.Options);
        }
    }
}
