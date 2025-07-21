using Microsoft.EntityFrameworkCore;
using ProjetoFdevs.Models;

namespace ProjetoFdevs.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        } 

        public DbSet<ContatoModel> Contatos { get; set; }
    }
}
