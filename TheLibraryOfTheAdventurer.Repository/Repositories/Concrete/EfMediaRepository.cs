using Core.Repository.Concrete;
using TheLibraryOfTheAdventurer.Model.Entities;
using TheLibraryOfTheAdventurer.Repository.Contexts;
using TheLibraryOfTheAdventurer.Repository.Repositories.Abstract;
namespace TheLibraryOfTheAdventurer.Repository.Repositories.Concrete;

public class EfMediaRepository : EfRepositoryBase<BaseDbContext, Media, Guid>, IMediaRepository
{
    public EfMediaRepository(BaseDbContext context) : base(context)
    {
    }
}
