namespace TheLibraryOfTheAdventurer.Model.Dtos.Users.Requests;

public sealed record RegisterUserRequestDto
{
    public required string Email { get; init; }
    public required string UserName { get; init; }
    public required string Password { get; init; }
    public int RoleId { get; init; }
}

