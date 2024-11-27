namespace TheLibraryOfTheAdventurer.Model.Dtos.Users.Requests;

public sealed record UpdateUserRequestDto
{
    public string Email { get; init; }
    public string UserName { get; init; }
    public string Password { get; init; }
    public int RoleId { get; init; }
}
