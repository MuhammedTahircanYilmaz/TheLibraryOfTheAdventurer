using Core.Entities;

namespace TheLibraryOfTheAdventurer.Model.Entities;

public class Review:Entity<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public float Rating { get; set; }
    public Guid MediaId { get; set; }
    public Media Media { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
}