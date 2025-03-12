using Microsoft.EntityFrameworkCore;

public class CitasAppDbContext : DbContext
{
    public CitasAppDbContext(DbContextOptions<CitasAppDbContext> options)
        : base(options)
    {
    }


}
