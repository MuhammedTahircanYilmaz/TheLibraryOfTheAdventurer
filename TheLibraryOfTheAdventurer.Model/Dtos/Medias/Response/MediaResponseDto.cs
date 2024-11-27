using TheLibraryOfTheAdventurer.Model.Entities.Dtos;
using TheLibraryOfTheAdventurer.Model.Enums;

namespace TheLibraryOfTheAdventurer.Model.Dtos.Medias.Response;

public record MediaResponseDto : EntityDtoBase<Guid>
{
    public string Title { get; init; }
    public string Description { get; init; }
    public string? Author { get; init; }
    public string? Studio { get; init; }
    public MediaType Type { get; init; }
    public Status Status { get; init; }
    public int? Rating { get; init; }
}
