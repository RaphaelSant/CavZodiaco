using CavZodiaco.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CavZodiaco.Core.Data;

public class CavaleirosContext : DbContext
{
    public DbSet<Cavaleiros> Cavaleiros { get; set; } = default!;
    public CavaleirosContext(DbContextOptions<CavaleirosContext> options) : base(options)
    {

    }
}
