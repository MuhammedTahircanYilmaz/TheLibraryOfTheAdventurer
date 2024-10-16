using Microsoft.EntityFrameworkCore;
using TheLibraryOfTheAdventurer.Model.Entities;

namespace TheLibraryOfTheAdventurer.Repository.Contexts;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions opt) : base(opt)
    {
    }
    public DbSet<Media> Medias { get; set; }
}
