using Core.Entities;

namespace TheLibraryOfTheAdventurer.Model.Entities;

public class Genre : Entity<int>
{
    public string Name { get; set; }
    public List<Media>? Medias { get; set; }
}
