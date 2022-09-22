using Microsoft.EntityFrameworkCore;
using MontadoraCarroApi.model;

namespace MontadoraCarroApi.data
{
    public class DbApllication : DbContext
    {
        public DbApllication(DbContextOptions<DbApllication> options)

            : base(options) => Database.EnsureCreated();
       
        public DbSet<Montadora> Montadora { get; set; }
        public DbSet<Carro> Carro { get; set; }
    }
    
}
