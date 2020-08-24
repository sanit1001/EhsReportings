using Ehs.Reporting.MR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Ehs.Reporting.Test
{
    public static class DbOptionsFactory
    {
        static DbOptionsFactory()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("app-settings-test.json").Build();
            var connectionString = config.GetConnectionString("EhsSqlContext");

            DbContextOptions = new DbContextOptionsBuilder<EhsSqlContext>()
                .UseSqlServer(connectionString)
                .Options;
        }

        public static DbContextOptions<EhsSqlContext> DbContextOptions { get; }

    }
}
