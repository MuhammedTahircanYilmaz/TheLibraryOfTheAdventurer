using TheLibraryOfTheAdventurer.Model.Entities.Dtos;
using TheLibraryOfTheAdventurer.Model.Enums;

namespace TheLibraryOfTheAdventurer.Model.Dtos.Medias.Requests;

public record UpdateMediaRequestDto
{
    public Guid Id { get; init; }
    public required string Title { get; init; }
    public required string Description { get; init; }
    public string? Author { get; init; }
    public string? Studio { get; init; }
    public required MediaType Type { get; init; }
    public required Status Status { get; init; }
    public int? Rating { get; init; }
}
