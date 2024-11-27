using Core.Entities;
using TheLibraryOfTheAdventurer.Model.Enums;

namespace TheLibraryOfTheAdventurer.Model.Entities;

public class Media : Entity<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public MediaType Type { get; set; }
    public List<Genre> Genres { get; set; }
    public Status Status { get; set; }
    public int? Rating { get; set; }
    public Guid ReviewId { get; set; }
    public Review Review { get; set; }
    
}
