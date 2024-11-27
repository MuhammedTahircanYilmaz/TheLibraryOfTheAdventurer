using Core.Entities;

namespace TheLibraryOfTheAdventurer.Model.Entities;

public class Category : Entity<int>
{
    public string Name { get; set; }
    public List<Genre>? Genres { get; set; }
}
