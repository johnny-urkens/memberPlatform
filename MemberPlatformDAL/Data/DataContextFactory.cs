using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MemberPlatformDAL.Data
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        // https://stackoverflow.com/questions/69410444/there-was-an-error-running-the-selected-code-generator-unable-to-resolve-servic

        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MemberPlatformApi;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer("Server=db1;Database=master;User=sa;Password=S3cur3P@ssW0rd!;");

            return new DataContext(optionsBuilder.Options);
        }
    }
}
