using Microsoft.EntityFrameworkCore;

namespace MasterPiece.Persistance.Contexts;

public class MasterPieceDbContext : DbContext
{
    public MasterPieceDbContext(DbContextOptions<MasterPieceDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer()
            .UseSnakeCaseNamingConvention();

    public DbSet<UserEntity> Users => Set<UserEntity>();
}