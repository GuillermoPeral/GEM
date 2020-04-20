namespace GEM.web.Data
{
    using GEM.web.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    public class DataContext : DbContext
    {
        DbSet<Gender> Genders { get; set; }
        DbSet<Client> Clients { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
