using Core.Entities;
using TheLibraryOfTheAdventurer.Model.Entities.Enums;

namespace TheLibraryOfTheAdventurer.Model.Entities;

public class Media : Entity<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string? Author { get; set; }
    public string? Studio { get; set; }
    public MediaType Type { get; set; }
    public Status Status { get; set; }
    public int Rating { get; set; }
}
