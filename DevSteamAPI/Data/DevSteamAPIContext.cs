using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DevSteamAPI.Data
{
    public class DevSteamAPIContext : IdentityDbContext
    {
        //Metodo construtor
        public DevSteamAPIContext(DbContextOptions<DevSteamAPIContext> options) : base(options)
        {
        }

        //Sobrescrever o metodo OnModelCrating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
