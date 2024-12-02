using Microsoft.EntityFrameworkCore;

namespace PIM_FINAL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Pedido> Pedido { get; set; }
    }
}
