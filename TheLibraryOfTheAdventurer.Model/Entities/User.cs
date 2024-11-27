using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace TheLibraryOfTheAdventurer.Model.Entities;

public class User : IdentityUser
{
    public int RoleId { get; set; }
    public required Role Role { get; set; }
    public List<Media>? Medias { get; set; }
    public List<Review>? Reviews { get; set; }
   
}
