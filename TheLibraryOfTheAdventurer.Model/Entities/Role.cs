using Core.Entities;

namespace TheLibraryOfTheAdventurer.Model.Entities;

public class Role : Entity<int>
{
    public string Name { get; set; }
    public List<User> Users { get; set; }
}
